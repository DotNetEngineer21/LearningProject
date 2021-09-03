using System.Threading.Tasks;
using Abp.Application.Services;
using CoreOSR.MultiTenancy.Payments.PayPal.Dto;

namespace CoreOSR.MultiTenancy.Payments.PayPal
{
    public interface IPayPalPaymentAppService : IApplicationService
    {
        Task ConfirmPayment(long paymentId, string paypalOrderId);

        PayPalConfigurationDto GetConfiguration();
    }
}
