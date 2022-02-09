using SampleProject.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace SampleProject.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class SampleProjectController : AbpControllerBase
{
    protected SampleProjectController()
    {
        LocalizationResource = typeof(SampleProjectResource);
    }
}
