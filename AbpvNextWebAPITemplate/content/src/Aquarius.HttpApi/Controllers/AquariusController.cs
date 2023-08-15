using Aquarius.Localization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StackExchange.Profiling;
using Volo.Abp.AspNetCore.Mvc;

namespace Aquarius.Controllers;

/* Inherit your controllers from this class.
 */
[ApiController]
[Route("api/v1/[Controller]")]
public class AquariusController : AbpControllerBase
{
    public AquariusController()
    {
        LocalizationResource = typeof(AquariusResource);
    }

    [HttpGet]
    public IActionResult GetCounts()
    {

        return Ok(true);
    }
}
