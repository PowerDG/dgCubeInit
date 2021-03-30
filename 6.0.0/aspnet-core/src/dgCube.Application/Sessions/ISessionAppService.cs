using System.Threading.Tasks;
using Abp.Application.Services;
using dgCube.Sessions.Dto;

namespace dgCube.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
