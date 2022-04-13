namespace ToDoListt.Server;
public class TaskUnitOfWork : BaseSettingsUnitOfWork<ToDoTask>, ITaskUnitOfWork
{
    public TaskUnitOfWork(ITaskRepository TaskRepository) : base(TaskRepository) { }
}

