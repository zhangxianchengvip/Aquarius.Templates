using System.Threading.Tasks;

namespace Aquarius.Data;

public interface IAquariusDbSchemaMigrator
{
    Task MigrateAsync();
}
