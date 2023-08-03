using System;
using System.Collections.Generic;
using System.Text;
using Aquarius.Localization;
using Volo.Abp.Application.Services;

namespace Aquarius;

/* Inherit your application services from this class.
 */
public abstract class AquariusAppService : ApplicationService
{
    protected AquariusAppService()
    {
        LocalizationResource = typeof(AquariusResource);
    }
}
