using Volo.Abp.Settings;

namespace Aquarius.Settings;

public class AquariusSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(AquariusSettings.MySetting1));
    }
}
