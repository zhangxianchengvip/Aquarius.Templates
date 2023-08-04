using EShopOnAbp.Localization;
using Volo.Abp.Localization;
using Volo.Abp.Localization.ExceptionHandling;
using Volo.Abp.Modularity;
using Volo.Abp.Validation;
using Volo.Abp.Validation.Localization;
using Volo.Abp.VirtualFileSystem;

namespace EShopOnAbp;

[DependsOn(
    typeof(AbpValidationModule)
    )]
public class EShopOnAbpDomainSharedModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<EShopOnAbpDomainSharedModule>(baseNamespace: "EShopOnAbp");
        });

        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Add<EShopOnAbpResource>("en")
                .AddBaseTypes(typeof(AbpValidationResource))
                .AddVirtualJson("/Localization/EShopOnAbp");

            options.DefaultResourceType = typeof(EShopOnAbpResource);
        });

        Configure<AbpExceptionLocalizationOptions>(options =>
        {
            options.MapCodeNamespace("EShopOnAbp", typeof(EShopOnAbpResource));
        });
    }
}
