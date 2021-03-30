using Abp.Authorization;
using dgCube.Authorization.Roles;
using dgCube.Authorization.Users;

namespace dgCube.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
