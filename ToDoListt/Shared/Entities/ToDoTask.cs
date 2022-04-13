namespace ToDoListt.Shared;
public class ToDoTask: BaseSettingsEntity
{
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string? Description { get; set; }
    public Boolean? Reminder { get; set; }
    public Guid ProfileId { get; set; }
    public Profile? profile { get; set; }
}
