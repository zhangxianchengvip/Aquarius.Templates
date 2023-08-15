using Volo.Abp.Application;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;

namespace Aquarius;

[DependsOn(
    typeof(AquariusDomainModule),
    typeof(AbpDddApplicationModule),
    typeof(AquariusApplicationContractsModule)
    )]
public class AquariusApplicationModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddMaps<AquariusApplicationModule>();
        });
    }
}
