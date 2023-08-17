using MediatR;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
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
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblyContaining<AquariusApplicationContractsModule>());
        context.Services.AddScoped(typeof(IPipelineBehavior<,>), typeof(ValidatorBehavior<,>));
        context.Services.AddScoped(typeof(IPipelineBehavior<,>), typeof(LoggingBehavior<,>));
    }
}
