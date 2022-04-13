using Duende.IdentityServer.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using ToDoListt.Server.Models;

namespace ToDoListt.Server;
public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions) { }

    //protected override void OnModelCreating(ModelBuilder modelBuilder)
    //    => modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      //  base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfiguration(new ProfileConfiguration())
                     .ApplyConfiguration(new ToDoTaskConfiguration());
    }
}
