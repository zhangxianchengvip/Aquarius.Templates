using Aquarius.Localization;
using Volo.Abp.Localization;
using Volo.Abp.Localization.ExceptionHandling;
using Volo.Abp.Modularity;
using Volo.Abp.Validation;
using Volo.Abp.Validation.Localization;
using Volo.Abp.VirtualFileSystem;

namespace Aquarius;

[DependsOn(
    typeof(AbpValidationModule)
    )]
public class AquariusDomainSharedModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        AquariusGlobalFeatureConfigurator.Configure();
        AquariusModuleExtensionConfigurator.Configure();
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<AquariusDomainSharedModule>(baseNamespace: "Aquarius");
        });

        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Add<AquariusResource>("zh-Hans")
                .AddBaseTypes(typeof(AbpValidationResource))
                .AddVirtualJson("/Localization/Aquarius");

            options.DefaultResourceType = typeof(AquariusResource);
        });

        Configure<AbpExceptionLocalizationOptions>(options =>
        {
            options.MapCodeNamespace("Aquarius.Exception", typeof(AquariusResource));
        });
    }
}
