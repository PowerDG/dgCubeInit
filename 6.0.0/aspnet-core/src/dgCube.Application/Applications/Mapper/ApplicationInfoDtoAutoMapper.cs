
using AutoMapper;
using dgCube;
using dgCube.Dtos;

// ReSharper disable once CheckNamespace
namespace dgCube.CustomDtoAutoMapper
{

	/// <summary>
    /// 配置ApplicationInfo的AutoMapper映射
	/// 前往 <see cref="dgCubeApplicationModule"/>的AbpAutoMapper配置方法下添加以下代码段
    /// ApplicationInfoDtoAutoMapper.CreateMappings(configuration);
    /// </summary>
	public static class ApplicationInfoDtoAutoMapper
    {
        public static void CreateMappings(IMapperConfigurationExpression configuration)
        {
            //configuration.CreateMap <ApplicationInfoApplicationInfoListDto>();
            configuration.CreateMap <ApplicationInfoListDto,ApplicationInfo>();

            configuration.CreateMap <ApplicationInfoEditDto,ApplicationInfo>();
            //configuration.CreateMap <ApplicationInfoApplicationInfoEditDto>();
					 
							//// custom codes
									
							

							//// custom codes end
        }
	}
}
