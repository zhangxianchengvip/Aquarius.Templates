using Volo.Abp.Application;
using Volo.Abp.Modularity;

namespace Aquarius;

[DependsOn(
    typeof(AbpDddApplicationContractsModule)
)]
public class AquariusApplicationContractsModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        AquariusDtoExtensions.Configure();
    }
}
