using Abp.Application.Services;
using Abp.Application.Services.Dto;
using CoreOSR.Authorization.Permissions.Dto;

namespace CoreOSR.Authorization.Permissions
{
    public interface IPermissionAppService : IApplicationService
    {
        ListResultDto<FlatPermissionWithLevelDto> GetAllPermissions();
    }
}
