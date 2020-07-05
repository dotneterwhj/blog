using Volo.Abp.Caching;
using Volo.Abp.Modularity;

namespace Nextload.Blog.HttpApplication.Cacheing
{
    [DependsOn(
        typeof(AbpCachingModule),
        typeof(BlogDomainModule)
    )]
    public class BlogHttpApplicationCacheingModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            base.ConfigureServices(context);
        }
    }
}