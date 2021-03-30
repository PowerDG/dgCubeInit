using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using dgCube.EntityFrameworkCore;
using dgCube.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace dgCube.Web.Tests
{
    [DependsOn(
        typeof(dgCubeWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class dgCubeWebTestModule : AbpModule
    {
        public dgCubeWebTestModule(dgCubeEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(dgCubeWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(dgCubeWebMvcModule).Assembly);
        }
    }
}