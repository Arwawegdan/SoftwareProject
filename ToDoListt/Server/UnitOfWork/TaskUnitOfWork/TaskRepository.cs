namespace ToDoListt.Server;
public class TaskRepository : BaseSettingsRepository<ToDoTask>, ITaskRepository
{
    public TaskRepository(ApplicationDbContext context) : base(context) { }
}