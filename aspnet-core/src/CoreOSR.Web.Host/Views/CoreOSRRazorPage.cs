using Abp.AspNetCore.Mvc.Views;

namespace CoreOSR.Web.Views
{
    public abstract class CoreOSRRazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected CoreOSRRazorPage()
        {
            LocalizationSourceName = CoreOSRConsts.LocalizationSourceName;
        }
    }
}
