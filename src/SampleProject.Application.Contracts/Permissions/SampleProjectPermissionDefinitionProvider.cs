using SampleProject.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace SampleProject.Permissions;

public class SampleProjectPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(SampleProjectPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(SampleProjectPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<SampleProjectResource>(name);
    }
}
