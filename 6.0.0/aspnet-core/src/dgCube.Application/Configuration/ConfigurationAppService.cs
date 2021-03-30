using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using dgCube.Configuration.Dto;

namespace dgCube.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : dgCubeAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
