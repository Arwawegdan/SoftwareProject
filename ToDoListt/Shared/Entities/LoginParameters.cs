namespace ToDoListt.Shared;

public class LoginParameters: BaseSettingsEntity
{
    public string UserName { get; set; }
    public string Password { get; set; }
    public bool RememberMe { get; set; }
}
