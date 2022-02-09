using Volo.Abp.Settings;

namespace SampleProject.Settings;

public class SampleProjectSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(SampleProjectSettings.MySetting1));
    }
}
