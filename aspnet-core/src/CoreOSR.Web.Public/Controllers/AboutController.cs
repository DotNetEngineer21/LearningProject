using Microsoft.AspNetCore.Mvc;
using CoreOSR.Web.Controllers;

namespace CoreOSR.Web.Public.Controllers
{
    public class AboutController : CoreOSRControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}