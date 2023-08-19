using Aquarius.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Aquarius.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(AquariusEntityFrameworkCoreModule),
    typeof(AquariusApplicationContractsModule)
    )]
public class AquariusDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
    }
}
