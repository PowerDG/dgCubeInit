using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using dgCube.Authorization;

namespace dgCube
{
    [DependsOn(
        typeof(dgCubeCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class dgCubeApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<dgCubeAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(dgCubeApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
