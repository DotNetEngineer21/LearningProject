using System.Threading.Tasks;
using Abp.Application.Services;
using CoreOSR.Sessions.Dto;

namespace CoreOSR.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();

        Task<UpdateUserSignInTokenOutput> UpdateUserSignInToken();
    }
}
