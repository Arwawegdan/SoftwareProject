namespace ToDoListt.Shared;

public class ProfileValidator : BaseSettingValidator<Profile>
{
    public ProfileValidator()
    {
        const int mobileMaxLength = 20;
        const int emailMaxLength = 200;

        RuleFor(e => e.Age).GreaterThanOrEqualTo(15)
            .WithMessage($"{typeof(Profile).Name} Age should be Greater Than Or Equal To 15");

        RuleFor(e => e.Mobile).NotNull().NotEmpty()
            .WithMessage($"{typeof(Profile).Name}  Mobile is required");

        RuleFor(e => e.Mobile).MaximumLength(mobileMaxLength)
            .WithMessage($"{typeof(Profile).Name}  Mobile MaximumLength is {mobileMaxLength}");

        RuleFor(e => e.Email).MaximumLength(emailMaxLength)
          .WithMessage($"{typeof(Profile).Name}  HiringDate MaximumLength is {emailMaxLength}");
    }
}
