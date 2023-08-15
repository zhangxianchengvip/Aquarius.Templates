using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Aquarius.Data;

/* This is used if database provider does't define
 * IAquariusDbSchemaMigrator implementation.
 */
public class NullAquariusDbSchemaMigrator : IAquariusDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
