using Abp.Application.Services;
using dgCube.MultiTenancy.Dto;

namespace dgCube.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

