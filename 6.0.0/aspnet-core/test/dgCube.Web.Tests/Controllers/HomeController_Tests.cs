using System.Threading.Tasks;
using dgCube.Models.TokenAuth;
using dgCube.Web.Controllers;
using Shouldly;
using Xunit;

namespace dgCube.Web.Tests.Controllers
{
    public class HomeController_Tests: dgCubeWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}