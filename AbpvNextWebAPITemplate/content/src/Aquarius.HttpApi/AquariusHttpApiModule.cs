using Aquarius.Localization;
using Localization.Resources.AbpUi;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;

namespace Aquarius;

[DependsOn(
    typeof(AquariusApplicationContractsModule)
    )]
public class AquariusHttpApiModule : AbpModule
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
                .Get<AquariusResource>()
                .AddBaseTypes(
                    typeof(AbpUiResource)
                );
        });
    }
}
