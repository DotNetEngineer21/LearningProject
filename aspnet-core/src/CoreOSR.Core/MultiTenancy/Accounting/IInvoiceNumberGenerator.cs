using System.Threading.Tasks;
using Abp.Dependency;

namespace CoreOSR.MultiTenancy.Accounting
{
    public interface IInvoiceNumberGenerator : ITransientDependency
    {
        Task<string> GetNewInvoiceNumber();
    }
}