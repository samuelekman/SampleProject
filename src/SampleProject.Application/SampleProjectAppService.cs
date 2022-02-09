using System;
using System.Collections.Generic;
using System.Text;
using SampleProject.Localization;
using Volo.Abp.Application.Services;

namespace SampleProject;

/* Inherit your application services from this class.
 */
public abstract class SampleProjectAppService : ApplicationService
{
    protected SampleProjectAppService()
    {
        LocalizationResource = typeof(SampleProjectResource);
    }
}
