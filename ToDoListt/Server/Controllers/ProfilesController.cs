using ToDoListt.Shared;

namespace ToDoList.Server;

[Route("api/[controller]")]
[ApiController]
public class ProfilesController : BaseSettingsController<Profile>
{
    public ProfilesController(IProfileUnitOfWork unitOfWork) : base(unitOfWork) { }
}