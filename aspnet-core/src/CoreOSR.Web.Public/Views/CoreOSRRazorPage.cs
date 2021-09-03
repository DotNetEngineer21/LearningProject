using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace CoreOSR.Web.Public.Views
{
    public abstract class CoreOSRRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected CoreOSRRazorPage()
        {
            LocalizationSourceName = CoreOSRConsts.LocalizationSourceName;
        }
    }
}
