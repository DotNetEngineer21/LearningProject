using System.Threading.Tasks;
using Abp.Application.Services;

namespace CoreOSR.MultiTenancy
{
    public interface ISubscriptionAppService : IApplicationService
    {
        Task DisableRecurringPayments();

        Task EnableRecurringPayments();
    }
}
