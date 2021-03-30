using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace dgCube.EntityFrameworkCore
{
    public static class dgCubeDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<dgCubeDbContext> builder, string connectionString)
        {
            builder.UseNpgsql(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<dgCubeDbContext> builder, DbConnection connection)
        {
            builder.UseNpgsql(connection);
        }
    }
}
