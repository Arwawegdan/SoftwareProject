namespace ToDoListt.Shared;
public class BaseSettingValidator<TEntity> : AbstractValidator<TEntity>
    where TEntity : BaseSettingsEntity
{
    public BaseSettingValidator()
    {
        const int nameMaxLength = 20;

        RuleFor(e => e.Name).NotEmpty().WithMessage($"{nameof(Profile)} Name is empty");
        RuleFor(e => e.Name).MaximumLength(nameMaxLength).WithMessage($"{nameof(Profile)} Name max length = {nameMaxLength}");
    }
}

