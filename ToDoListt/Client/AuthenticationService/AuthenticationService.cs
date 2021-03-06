using System.Text;
using System.Text.Json;

namespace ToDoListt.Client;

public class AuthenticationService : IAuthenticationService
{
    private readonly HttpClient _client;
    private readonly JsonSerializerOptions _options;

    public AuthenticationService(HttpClient client)
    {
        _client = client;
        _options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
    }

    public async Task<RegistrationResponse> RegisterUser(RegisterParameters userForRegistration)
    {
        var content = JsonSerializer.Serialize(userForRegistration);
        var bodyContent = new StringContent(content, Encoding.UTF8, "application/json");

        var registrationResult = await _client.PostAsync("accounts/registration", bodyContent);
        var registrationContent = await registrationResult.Content.ReadAsStringAsync();

        if (!registrationResult.IsSuccessStatusCode)
        {
            var result = JsonSerializer.Deserialize<RegistrationResponse>(registrationContent, _options);
            return result;
        }

        return new RegistrationResponse { IsSuccessfulRegistration = true };
    }
}