namespace ToDoListt.Server;
public class ToDoTaskConfiguration : BaseEntityConfiguration<ToDoTask>
{
    public override void Configure(EntityTypeBuilder<ToDoTask> builder)
    {
        base.Configure(builder);
        builder.ToTable("Tasks");

        builder.HasOne(e => e.profile).WithMany().HasForeignKey(e=>e.ProfileId);
    }
}
