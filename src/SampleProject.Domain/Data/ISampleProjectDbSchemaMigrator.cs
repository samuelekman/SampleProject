using System.Threading.Tasks;

namespace SampleProject.Data;

public interface ISampleProjectDbSchemaMigrator
{
    Task MigrateAsync();
}
