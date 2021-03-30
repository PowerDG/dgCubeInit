using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using dgCube.Configuration;
using dgCube.Web;

namespace dgCube.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class dgCubeDbContextFactory : IDesignTimeDbContextFactory<dgCubeDbContext>
    {
        public dgCubeDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<dgCubeDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            dgCubeDbContextConfigurer.Configure(builder, configuration.GetConnectionString(dgCubeConsts.ConnectionStringName));

            return new dgCubeDbContext(builder.Options);
        }
    }
}
