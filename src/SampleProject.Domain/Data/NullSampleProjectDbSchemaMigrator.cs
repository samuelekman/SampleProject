using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace SampleProject.Data;

/* This is used if database provider does't define
 * ISampleProjectDbSchemaMigrator implementation.
 */
public class NullSampleProjectDbSchemaMigrator : ISampleProjectDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
