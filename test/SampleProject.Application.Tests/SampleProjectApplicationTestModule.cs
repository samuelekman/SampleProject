using Volo.Abp.Modularity;

namespace SampleProject;

[DependsOn(
    typeof(SampleProjectApplicationModule),
    typeof(SampleProjectDomainTestModule)
    )]
public class SampleProjectApplicationTestModule : AbpModule
{

}
