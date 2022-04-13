namespace ToDoListt.Server;
public class ProfileRepository : BaseSettingsRepository<Profile>, IProfileRepository
{
    public ProfileRepository(ApplicationDbContext context) : base(context) { }
}