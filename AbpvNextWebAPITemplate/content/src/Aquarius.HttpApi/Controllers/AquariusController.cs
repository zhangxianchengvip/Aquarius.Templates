using Aquarius.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Aquarius.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class AquariusController : AbpControllerBase
{
    protected AquariusController()
    {
        LocalizationResource = typeof(AquariusResource);
    }
}
