using System.Collections.Generic;
using CoreOSR.Authorization.Users.Importing.Dto;
using Abp.Dependency;

namespace CoreOSR.Authorization.Users.Importing
{
    public interface IUserListExcelDataReader: ITransientDependency
    {
        List<ImportUserDto> GetUsersFromExcel(byte[] fileBytes);
    }
}
