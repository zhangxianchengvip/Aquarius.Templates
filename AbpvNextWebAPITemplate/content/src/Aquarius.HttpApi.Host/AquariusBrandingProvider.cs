using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Aquarius;

[Dependency(ReplaceServices = true)]
public class AquariusBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Aquarius";
}
