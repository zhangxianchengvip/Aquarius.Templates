using Volo.Abp.Application;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;

namespace EShopOnAbp;

[DependsOn(
    typeof(EShopOnAbpDomainModule),
    typeof(AbpAutoMapperModule),
    typeof(EShopOnAbpApplicationContractsModule),
    typeof(AbpDddApplicationModule)
    )]
public class EShopOnAbpApplicationModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddMaps<EShopOnAbpApplicationModule>();
        });
    }
}
