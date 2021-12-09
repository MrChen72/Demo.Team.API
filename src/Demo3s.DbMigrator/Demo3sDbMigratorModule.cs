using Demo3s.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Demo3s.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(Demo3sEntityFrameworkCoreModule),
        typeof(Demo3sApplicationContractsModule)
        )]
    public class Demo3sDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
