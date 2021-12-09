using Volo.Abp.Settings;

namespace Demo3s.Settings
{
    public class Demo3sSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(Demo3sSettings.MySetting1));
        }
    }
}
