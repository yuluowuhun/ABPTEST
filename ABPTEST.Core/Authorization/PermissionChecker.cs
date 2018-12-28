using Abp.Authorization;
using ABPTEST.Authorization.Roles;
using ABPTEST.Authorization.Users;

namespace ABPTEST.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
