using SampleProject.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace SampleProject;

[DependsOn(
    typeof(SampleProjectEntityFrameworkCoreTestModule)
    )]
public class SampleProjectDomainTestModule : AbpModule
{

}
