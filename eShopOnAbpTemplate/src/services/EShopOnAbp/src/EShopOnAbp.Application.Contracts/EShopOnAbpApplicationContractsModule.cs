using Volo.Abp.Application;
using Volo.Abp.Modularity;

namespace EShopOnAbp;

[DependsOn(
    typeof(AbpDddApplicationContractsModule)
)]
public class EShopOnAbpApplicationContractsModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        EShopOnAbpDtoExtensions.Configure();
    }
}
