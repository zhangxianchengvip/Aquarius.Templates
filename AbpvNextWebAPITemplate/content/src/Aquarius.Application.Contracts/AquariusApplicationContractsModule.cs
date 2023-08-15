using Volo.Abp.Modularity;
using Volo.Abp.ObjectExtending;

namespace Aquarius;

[DependsOn(
    typeof(AquariusDomainSharedModule),
    typeof(AbpObjectExtendingModule)
)]
public class AquariusApplicationContractsModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        AquariusDtoExtensions.Configure();
    }
}
