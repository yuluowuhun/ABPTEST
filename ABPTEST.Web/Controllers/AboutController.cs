using System.Web.Mvc;

namespace ABPTEST.Web.Controllers
{
    public class AboutController : ABPTESTControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}