using System.Threading.Tasks;
using dgCube.Configuration.Dto;

namespace dgCube.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
