
using System;
using Abp.Application.Services;
using Abp.Application.Services.Dto;

using System.Collections.Generic;
using System.Threading.Tasks;
using dgCube.Dtos;
using dgCube;



namespace dgCube
{
    /// <summary>
    /// 应用层服务的接口方法
    ///</summary>
    public interface IApplicationInfoAppService : IApplicationService
    {
        /// <summary>
		/// 获取的分页列表集合
		///</summary>
        /// <param name="input"></param>
        /// <returns></returns>
        //Task<PagedResultDto<ApplicationInfoListDto>> GetPaged(GetApplicationInfosInput input);

         

        /// <summary>
        /// 添加或者修改的公共方法
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task CreateOrUpdate(CreateOrUpdateApplicationInfoInput input);
         
    }
}
