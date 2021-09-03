using Abp.AspNetCore.Mvc.ViewComponents;

namespace CoreOSR.Web.Public.Views
{
    public abstract class CoreOSRViewComponent : AbpViewComponent
    {
        protected CoreOSRViewComponent()
        {
            LocalizationSourceName = CoreOSRConsts.LocalizationSourceName;
        }
    }
}