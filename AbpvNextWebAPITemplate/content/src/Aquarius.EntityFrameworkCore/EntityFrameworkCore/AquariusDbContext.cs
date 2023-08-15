using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;

namespace Aquarius.EntityFrameworkCore;

[ConnectionStringName("Default")]
public class AquariusDbContext :AbpDbContext<AquariusDbContext>
{

    #region Entities from the modules


    #endregion

    public AquariusDbContext(DbContextOptions<AquariusDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }
}
