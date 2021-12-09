using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Demo3s
{
    [Dependency(ReplaceServices = true)]
    public class Demo3sBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "Demo3s";
    }
}
