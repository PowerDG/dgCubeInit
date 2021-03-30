

using System.Linq;
using Abp;
using Abp.Authorization;
using Abp.Configuration.Startup;
using Abp.Localization;
using Abp.MultiTenancy;
using dgCube.Authorization;

// ReSharper disable once CheckNamespace
namespace dgCube.Authorization
{
    /// <summary>
    /// 权限配置都在这里。
    /// 给权限默认设置服务
    /// See <see cref="ApplicationInfoPermissions" /> for all permission names. ApplicationInfo
    ///</summary>
    public class ApplicationInfoAuthorizationProvider : AuthorizationProvider
    {
        private readonly bool _isMultiTenancyEnabled;

        public object AppPermissions { get; private set; }

        public ApplicationInfoAuthorizationProvider()
		{

		}

       
        public ApplicationInfoAuthorizationProvider(bool isMultiTenancyEnabled)
        {
            _isMultiTenancyEnabled = isMultiTenancyEnabled;
        }

        public ApplicationInfoAuthorizationProvider(IMultiTenancyConfig multiTenancyConfig)
        {
            _isMultiTenancyEnabled = multiTenancyConfig.IsEnabled;
        }

		public override void SetPermissions(IPermissionDefinitionContext context)
		{
//			// 在这里配置了ApplicationInfo 的权限。
//			var pages = context.GetPermissionOrNull(AppPermissions.Pages) ?? context.CreatePermission(AppPermissions.Pages, L("Pages"));

//			var administration = pages.Children.FirstOrDefault(p => p.Name == AppPermissions.Pages_Administration) ?? pages.CreateChildPermission(AppPermissions.Pages_Administration, L("Administration"));

//			var applicationInfo = administration.CreateChildPermission(ApplicationInfoPermissions.ApplicationInfo_Node , L("ApplicationInfo"));
//applicationInfo.CreateChildPermission(ApplicationInfoPermissions.ApplicationInfo_Query, L("QueryApplicationInfo"));
//applicationInfo.CreateChildPermission(ApplicationInfoPermissions.ApplicationInfo_Create, L("CreateApplicationInfo"));
//applicationInfo.CreateChildPermission(ApplicationInfoPermissions.ApplicationInfo_Edit, L("EditApplicationInfo"));
//applicationInfo.CreateChildPermission(ApplicationInfoPermissions.ApplicationInfo_Delete, L("DeleteApplicationInfo"));
//applicationInfo.CreateChildPermission(ApplicationInfoPermissions.ApplicationInfo_BatchDelete, L("BatchDeleteApplicationInfo"));
//applicationInfo.CreateChildPermission(ApplicationInfoPermissions.ApplicationInfo_ExportExcel, L("ExportToExcel"));

			
							//// custom codes
									
							

							//// custom codes end
		}

		private static ILocalizableString L(string name)
		{
			return new LocalizableString(name, AbpConsts.LocalizationSourceName);
		}
    }
}
