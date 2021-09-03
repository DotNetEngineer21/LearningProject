using Microsoft.AspNetCore.Mvc;
using CoreOSR.Web.Controllers;

namespace CoreOSR.Web.Public.Controllers
{
    public class HomeController : CoreOSRControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}