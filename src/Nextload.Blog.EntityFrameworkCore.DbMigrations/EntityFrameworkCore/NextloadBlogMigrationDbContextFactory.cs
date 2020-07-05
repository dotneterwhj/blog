using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Nextload.Blog.EntityFrameworkCore
{
    internal class NextloadBlogMigrationDbContextFactory : IDesignTimeDbContextFactory<NextloadBlogMigrationDbContext>
    {
        public NextloadBlogMigrationDbContext CreateDbContext(string[] args)
        {
            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<NextloadBlogMigrationDbContext>()
                .UseMySql(configuration.GetConnectionString("Default"));

            return new NextloadBlogMigrationDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            return builder.Build();
        }
    }
}
