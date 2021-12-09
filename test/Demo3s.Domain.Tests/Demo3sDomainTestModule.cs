using Demo3s.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Demo3s
{
    [DependsOn(
        typeof(Demo3sEntityFrameworkCoreTestModule)
        )]
    public class Demo3sDomainTestModule : AbpModule
    {

    }
}