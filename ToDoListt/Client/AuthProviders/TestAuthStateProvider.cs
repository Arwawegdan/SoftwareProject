using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;

namespace ToDoListt.Client;

public class TestAuthStateProvider : AuthenticationStateProvider
{
    public async override Task<AuthenticationState> GetAuthenticationStateAsync()
    {
        ClaimsIdentity anonymous = new ClaimsIdentity();
        return await Task.FromResult(new AuthenticationState(new ClaimsPrincipal(anonymous)));
    }
}
