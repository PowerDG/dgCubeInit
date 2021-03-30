using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using dgCube.MultiTenancy;

namespace dgCube.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}
