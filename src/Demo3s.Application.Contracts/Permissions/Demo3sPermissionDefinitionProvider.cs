using Demo3s.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Demo3s.Permissions
{
    public class Demo3sPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(Demo3sPermissions.GroupName);
            //Define your own permissions here. Example:
            //myGroup.AddPermission(Demo3sPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<Demo3sResource>(name);
        }
    }
}
