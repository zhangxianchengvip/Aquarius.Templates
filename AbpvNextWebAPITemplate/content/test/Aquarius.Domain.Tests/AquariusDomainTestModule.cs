using Aquarius.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Aquarius;

[DependsOn(
    typeof(AquariusEntityFrameworkCoreTestModule)
    )]
public class AquariusDomainTestModule : AbpModule
{

}
