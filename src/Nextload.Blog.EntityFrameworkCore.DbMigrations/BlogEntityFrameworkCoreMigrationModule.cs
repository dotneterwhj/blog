using Microsoft.Extensions.DependencyInjection;
using Nextload.Blog.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Nextload.Blog
{
    [DependsOn(
        typeof(BlogEntityFrameworkCoreModule)
    )]
    public class BlogEntityFrameworkCoreMigrationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<NextloadBlogMigrationDbContext>();
        }
    }
}