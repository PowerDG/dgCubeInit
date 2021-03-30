using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using dgCube.Authorization.Roles;
using dgCube.Authorization.Users;
using dgCube.MultiTenancy;

namespace dgCube.EntityFrameworkCore
{
    public class dgCubeDbContext : AbpZeroDbContext<Tenant, Role, User, dgCubeDbContext>
    {
        /* Define a DbSet for each entity of the application */

        public dgCubeDbContext(DbContextOptions<dgCubeDbContext> options)
            : base(options)
        {

        }
        public virtual DbSet<ExternalSMLog> ExternalSMLogs { get; set; }
        public virtual DbSet<ApplicationInfo> ApplicationInfos { get; set; }
        
    }
 
}
