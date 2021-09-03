using System.Collections.Generic;
using CoreOSR.Authorization.Users.Importing.Dto;
using CoreOSR.Dto;

namespace CoreOSR.Authorization.Users.Importing
{
    public interface IInvalidUserExporter
    {
        FileDto ExportToFile(List<ImportUserDto> userListDtos);
    }
}
