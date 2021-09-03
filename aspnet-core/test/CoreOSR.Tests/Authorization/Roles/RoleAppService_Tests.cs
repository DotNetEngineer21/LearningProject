using System.Threading.Tasks;
using CoreOSR.Authorization.Roles;
using CoreOSR.Authorization.Roles.Dto;
using CoreOSR.Test.Base;
using Shouldly;
using Xunit;

namespace CoreOSR.Tests.Authorization.Roles
{
    // ReSharper disable once InconsistentNaming
    public class RoleAppService_Tests : AppTestBase
    {
        private readonly IRoleAppService _roleAppService;

        public RoleAppService_Tests()
        {
            _roleAppService = Resolve<IRoleAppService>();
        }

        [MultiTenantFact]
        public async Task Should_Get_Roles_For_Host()
        {
            LoginAsHostAdmin();

            //Act
            var output = await _roleAppService.GetRoles(new GetRolesInput());

            //Assert
            output.Items.Count.ShouldBe(1);
        }

        [Fact]
        public async Task Should_Get_Roles_For_Tenant()
        {
            //Act
            var output = await _roleAppService.GetRoles(new GetRolesInput());

            //Assert
            output.Items.Count.ShouldBe(2);
        }
    }
}
