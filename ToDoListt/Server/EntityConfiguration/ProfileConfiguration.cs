namespace ToDoListt.Server;
public class ProfileConfiguration : BaseEntityConfiguration<Profile>
{
    public override void Configure(EntityTypeBuilder<Profile> builder)
    {
        base.Configure(builder);

        builder.ToTable("Profiles");

        builder.Property(e => e.Age).HasMaxLength(20);
        builder.Property(e => e.Mobile).HasMaxLength(50);
        builder.Property(e => e.Email).IsRequired();
        builder.Property(e => e.Email).HasMaxLength(25);


    }
}
