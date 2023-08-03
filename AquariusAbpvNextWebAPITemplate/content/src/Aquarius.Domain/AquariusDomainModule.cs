using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace Aquarius;

[DependsOn(
    typeof(AquariusDomainSharedModule),
    typeof(AbpDddDomainModule)
)]
public class AquariusDomainModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
    }
}
