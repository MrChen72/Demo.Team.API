using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Demo3s.Data;
using Volo.Abp.DependencyInjection;

namespace Demo3s.EntityFrameworkCore
{
    public class EntityFrameworkCoreDemo3sDbSchemaMigrator
        : IDemo3sDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreDemo3sDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the Demo3sDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<Demo3sDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}
