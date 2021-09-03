using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using CoreOSR.MultiTenancy.Accounting.Dto;

namespace CoreOSR.MultiTenancy.Accounting
{
    public interface IInvoiceAppService
    {
        Task<InvoiceDto> GetInvoiceInfo(EntityDto<long> input);

        Task CreateInvoice(CreateInvoiceDto input);
    }
}
