using EShopOnAbp.Localization;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;

namespace EShopOnAbp;

[DependsOn(
    typeof(EShopOnAbpApplicationContractsModule)
    )]
public class EShopOnAbpHttpApiModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        ConfigureLocalization();
    }

    private void ConfigureLocalization()
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<EShopOnAbpResource>()
                .AddBaseTypes(
                    typeof(EShopOnAbpHttpApiModule)
                );
        });
    }
}
