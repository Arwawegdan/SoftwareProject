namespace ToDoListt.Shared;

public class LoginParametersValidator : BaseSettingValidator<LoginParameters>
{
    public LoginParametersValidator()
    {
        RuleFor(e => e.UserName).NotEmpty()
            .WithMessage("UserName is Required");

        RuleFor(e => e.Password).NotNull().NotEmpty()
            .WithMessage("Password is required");

    }
}
