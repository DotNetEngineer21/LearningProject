using Abp.AspNetCore.Mvc.Authorization;
using CoreOSR.Authorization;
using CoreOSR.Storage;
using Abp.BackgroundJobs;

namespace CoreOSR.Web.Controllers
{
    [AbpMvcAuthorize(AppPermissions.Pages_Administration_Users)]
    public class UsersController : UsersControllerBase
    {
        public UsersController(IBinaryObjectManager binaryObjectManager, IBackgroundJobManager backgroundJobManager)
            : base(binaryObjectManager, backgroundJobManager)
        {
        }
    }
}