using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace EShopOnAbp;

[DependsOn(
    typeof(EShopOnAbpDomainSharedModule),
    typeof(AbpDddDomainModule)
)]
public class EShopOnAbpDomainModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
    }
}
