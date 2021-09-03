using System.Collections.Generic;
using CoreOSR.Authorization.Permissions.Dto;

namespace CoreOSR.Authorization.Users.Dto
{
    public class GetUserPermissionsForEditOutput
    {
        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}