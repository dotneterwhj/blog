using Microsoft.Extensions.DependencyInjection;
using Nextload.Blog.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.MySQL;
using Volo.Abp.Modularity;

namespace Nextload.Blog
{
    [DependsOn(
        typeof(BlogDomainModule),
        typeof(AbpEntityFrameworkCoreModule),
        typeof(AbpEntityFrameworkCoreMySQLModule)
    )]
    public class BlogEntityFrameworkCoreModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<NextloadBlogDbContext>(options =>
            {
                // 默认情况下为每个实体创建一个仓储，如果想要为其他实体也创建仓储，可以将 includeAllEntities 设置为 true
                options.AddDefaultRepositories(includeAllEntities: true);

                Configure<AbpDbContextOptions>(options =>
                {
                    switch (AppSettings.EnableDb)
                    {
                        default:
                        case "MySql":
                            options.UseMySQL();
                            break;
                    }
                });
            });
        }
    }
}