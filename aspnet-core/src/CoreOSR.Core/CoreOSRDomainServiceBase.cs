using Abp.Domain.Services;

namespace CoreOSR
{
    public abstract class CoreOSRDomainServiceBase : DomainService
    {
        /* Add your common members for all your domain services. */

        protected CoreOSRDomainServiceBase()
        {
            LocalizationSourceName = CoreOSRConsts.LocalizationSourceName;
        }
    }
}
