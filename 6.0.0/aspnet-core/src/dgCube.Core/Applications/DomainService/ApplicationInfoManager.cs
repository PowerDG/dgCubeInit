

using Abp.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace dgCube.dgDomainService
{
    /// <summary>
    /// 领域服务层一个模块的核心业务逻辑
    ///</summary>
    public class ApplicationInfoManager :dgCubeDomainServiceBase, IApplicationInfoManager
    {
		
		private readonly IRepository<ApplicationInfo> _applicationInfoRepository;

		/// <summary>
		/// ApplicationInfo的构造方法
		/// 通过构造函数注册服务到依赖注入容器中
		///</summary>
	public ApplicationInfoManager(IRepository<ApplicationInfo > applicationInfoRepository)	{
			_applicationInfoRepository =  applicationInfoRepository;
		}

		 #region 查询判断的业务

        /// <summary>
        /// 返回表达式数的实体信息即IQueryable类型
        /// </summary>
        /// <returns></returns>
        public IQueryable<ApplicationInfo> QueryApplicationInfos()
        {
            return _applicationInfoRepository.GetAll();
        }

        /// <summary>
        /// 返回即IQueryable类型的实体，不包含EF Core跟踪标记
        /// </summary>
        /// <returns></returns>
        public IQueryable<ApplicationInfo> QueryApplicationInfosAsNoTracking()
        {
            return _applicationInfoRepository.GetAll().AsNoTracking();
        }

        /// <summary>
        /// 根据Id查询实体信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<ApplicationInfo> FindByIdAsync(int id)
        {
            var entity = await _applicationInfoRepository.GetAsync(id);
            return entity;
        }

        /// <summary>
        /// 检查实体是否存在
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<bool> IsExistAsync( int id)
        {
            var result = await _applicationInfoRepository.GetAll().AnyAsync(a => a.Id == id);
            return result;
        }

        #endregion

		 
		 
        public async Task<ApplicationInfo> CreateAsync(ApplicationInfo entity)
        {
            entity.Id = await _applicationInfoRepository.InsertAndGetIdAsync(entity);
            return entity;
        }

        public async Task UpdateAsync(ApplicationInfo entity)
        {
            await _applicationInfoRepository.UpdateAsync(entity);
        }

        public async Task DeleteAsync(int id)
        {
            //TODO:删除前的逻辑判断，是否允许删除
            await _applicationInfoRepository.DeleteAsync(id);
        }
         


		 
		  
		 

	}
}
