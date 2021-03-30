using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace dgCube.Controllers
{
    public abstract class dgCubeControllerBase: AbpController
    {
        protected dgCubeControllerBase()
        {
            LocalizationSourceName = dgCubeConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
