namespace ToDoListt.Server;
public class ProfileUnitOfWork : BaseSettingsUnitOfWork<Profile>, IProfileUnitOfWork
{
    public ProfileUnitOfWork(IProfileRepository ProfileRepository) : base(ProfileRepository) { }
}


