using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using dgCube.Configuration;

namespace dgCube.Web.Host.Startup
{
    [DependsOn(
       typeof(dgCubeWebCoreModule))]
    public class dgCubeWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public dgCubeWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(dgCubeWebHostModule).GetAssembly());
        }
    }
}
