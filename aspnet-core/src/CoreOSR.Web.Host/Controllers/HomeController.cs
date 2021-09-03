using Abp.Auditing;
using Microsoft.AspNetCore.Mvc;

namespace CoreOSR.Web.Controllers
{
    public class HomeController : CoreOSRControllerBase
    {
        [DisableAuditing]
        public IActionResult Index()
        {
            return RedirectToAction("Index", "Ui");
        }
    }
}
