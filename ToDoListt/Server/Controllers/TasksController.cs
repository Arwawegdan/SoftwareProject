using ToDoListt.Shared;

namespace ToDoList.Server;

[Route("api/[controller]")]
[ApiController]
public class TasksController : BaseSettingsController<ToDoTask>
{
    public TasksController(ITaskUnitOfWork unitOfWork) : base(unitOfWork) { }
}