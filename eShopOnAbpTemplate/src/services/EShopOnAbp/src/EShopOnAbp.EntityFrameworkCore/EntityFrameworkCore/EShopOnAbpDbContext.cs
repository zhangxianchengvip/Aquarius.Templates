using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace EShopOnAbp.EntityFrameworkCore;

[ConnectionStringName("Default")]
public class EShopOnAbpDbContext :AbpDbContext<EShopOnAbpDbContext>
{
    /* Add DbSet properties for your Aggregate Roots / Entities here. */

    #region Entities from the modules

    #endregion

    public EShopOnAbpDbContext(DbContextOptions<EShopOnAbpDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }
}
