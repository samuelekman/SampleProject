﻿using SampleProject.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace SampleProject.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(SampleProjectEntityFrameworkCoreModule),
    typeof(SampleProjectApplicationContractsModule)
    )]
public class SampleProjectDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
