
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.AutoMapper;
using Abp.Linq.Extensions;
using Abp.Extensions;
using Abp.Domain.Repositories;


using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;
using dgCube;
using dgCube.Dtos; 
using dgCube.dgDomainService;
using dgCube.Authorization;

namespace dgCube
{
    /// <summary>
    /// 应用层服务的接口实现方法
    ///
  ///</summary>
    [AbpAuthorize]
    public class ApplicationInfoAppService : dgCubeAppServiceBase, IApplicationInfoAppService
    {
    private readonly IRepository<ApplicationInfo >
        _applicationInfoRepository;
		 

        private readonly IApplicationInfoManager _applicationInfoManager;
        /// <summary>
            /// 构造函数
            ///
        ///</summary>
        public ApplicationInfoAppService(
        IRepository<ApplicationInfo >
applicationInfoRepository
            ,IApplicationInfoManager applicationInfoManager 
            )
            {
            _applicationInfoRepository = applicationInfoRepository;
             _applicationInfoManager=applicationInfoManager; 

            }

		 

		/// <summary>
		/// 获取编辑 
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
//		[AbpAuthorize(ApplicationInfoPermissions.ApplicationInfo_Create,ApplicationInfoPermissions.ApplicationInfo_Edit)]
//		public async Task<GetApplicationInfoForEditOutput> GetForEdit(NullableIdDto<> input)
//		{
//			var output = new GetApplicationInfoForEditOutput();
//ApplicationInfoEditDto editDto;

//			if (input.Id.HasValue)
//			{
//				var entity = await _applicationInfoRepository.GetAsync(input.Id.Value);
//				editDto = ObjectMapper.Map<ApplicationInfoEditDto>(entity);
//			}
//			else
//			{
//				editDto = new ApplicationInfoEditDto();
//			}



  //          output.ApplicationInfo = editDto;
		//	return output;
		//}


		/// <summary>
		/// 添加或者修改的公共方法
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		[AbpAuthorize(ApplicationInfoPermissions.ApplicationInfo_Create,ApplicationInfoPermissions.ApplicationInfo_Edit)]
		public async Task CreateOrUpdate(CreateOrUpdateApplicationInfoInput input)
		{

			if (input.ApplicationInfo.Id.HasValue)
			{ 
			}
			else
			{
				await Create(input.ApplicationInfo);
			}
		}


		/// <summary>
		/// 新增
		/// </summary>
		[AbpAuthorize(ApplicationInfoPermissions.ApplicationInfo_Create)]
		protected virtual async Task<ApplicationInfoEditDto> Create(ApplicationInfoEditDto input)
		{
			//TODO:新增前的逻辑判断，是否允许新增

            var entity = ObjectMapper.Map<ApplicationInfo>(input);
            //调用领域服务
            entity = await _applicationInfoManager.CreateAsync(entity);

            var dto=ObjectMapper.Map<ApplicationInfoEditDto>(entity);
            return dto;
		}
		 

		 


	 
 
		 

    }
}


