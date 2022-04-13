namespace ToDoListt.Client;
public interface IAuthenticationService
{
    Task<RegistrationResponse> RegisterUser(RegisterParameters registerParameters);

}
