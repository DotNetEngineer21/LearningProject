using Abp.Authorization;
using CoreOSR.Authorization.Roles;
using CoreOSR.Authorization.Users;

namespace CoreOSR.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
