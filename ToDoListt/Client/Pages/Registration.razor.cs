﻿namespace ToDoListt.Client;

public partial class Registration
{
    private RegisterParameters _userForRegistration = new RegisterParameters();

    [Inject]
    public IAuthenticationService AuthenticationService { get; set; }
    [Inject]
    public NavigationManager NavigationManager { get; set; }
    public bool ShowRegistrationErrors { get; set; }
    public IEnumerable<string> Errors { get; set; }

    public async Task Register()
    {
        ShowRegistrationErrors = false;

        var result = await AuthenticationService.RegisterUser(_userForRegistration);
        if (!result.IsSuccessfulRegistration)
        {
            Errors = result.Errors;
            ShowRegistrationErrors = true;
        }
        else
        {
            NavigationManager.NavigateTo("/");
        }
    }
}