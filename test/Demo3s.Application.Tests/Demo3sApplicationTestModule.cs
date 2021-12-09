using Volo.Abp.Modularity;

namespace Demo3s
{
    [DependsOn(
        typeof(Demo3sApplicationModule),
        typeof(Demo3sDomainTestModule)
        )]
    public class Demo3sApplicationTestModule : AbpModule
    {

    }
}