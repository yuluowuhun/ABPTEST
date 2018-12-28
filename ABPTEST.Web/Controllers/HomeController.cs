using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace ABPTEST.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : ABPTESTControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}