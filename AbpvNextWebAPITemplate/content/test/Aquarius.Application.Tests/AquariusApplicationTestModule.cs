using Volo.Abp.Modularity;

namespace Aquarius;

[DependsOn(
    typeof(AquariusApplicationModule),
    typeof(AquariusDomainTestModule)
    )]
public class AquariusApplicationTestModule : AbpModule
{

}
