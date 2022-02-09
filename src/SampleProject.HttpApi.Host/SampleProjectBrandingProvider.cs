using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace SampleProject;

[Dependency(ReplaceServices = true)]
public class SampleProjectBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "SampleProject";
}
