using EShopOnAbp.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace EShopOnAbp.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class EShopOnAbpController : AbpControllerBase
{
    protected EShopOnAbpController()
    {
        LocalizationResource = typeof(EShopOnAbpResource);
    }
}
