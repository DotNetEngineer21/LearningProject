using System.Threading.Tasks;
using CoreOSR.Sessions.Dto;

namespace CoreOSR.Web.Session
{
    public interface IPerRequestSessionCache
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformationsAsync();
    }
}
