using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Demo3s.Data
{
    /* This is used if database provider does't define
     * IDemo3sDbSchemaMigrator implementation.
     */
    public class NullDemo3sDbSchemaMigrator : IDemo3sDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}