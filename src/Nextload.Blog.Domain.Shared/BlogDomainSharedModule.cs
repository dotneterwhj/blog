using Volo.Abp.Identity;
using Volo.Abp.Modularity;

namespace Nextload.Blog
{
    [DependsOn(
        typeof(AbpIdentityDomainSharedModule)
    )]
    public class BlogDomainSharedModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
        }
    }
}