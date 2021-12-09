using System.Threading.Tasks;

namespace Demo3s.Data
{
    public interface IDemo3sDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
