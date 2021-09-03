using System.Collections.Generic;
using CoreOSR.Authorization.Users.Dto;
using CoreOSR.Dto;

namespace CoreOSR.Authorization.Users.Exporting
{
    public interface IUserListExcelExporter
    {
        FileDto ExportToFile(List<UserListDto> userListDtos);
    }
}