using System.Collections.Generic;
using System.Threading.Tasks;
using Abp;
using CoreOSR.Dto;

namespace CoreOSR.Gdpr
{
    public interface IUserCollectedDataProvider
    {
        Task<List<FileDto>> GetFiles(UserIdentifier user);
    }
}
