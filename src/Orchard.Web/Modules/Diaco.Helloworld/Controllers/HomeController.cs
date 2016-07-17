using System.Web.Mvc;
using Orchard.Themes;

namespace Diaco.KimiaRazi.Controllers
{
    [Themed]
    public class HomeController : Controller {
        public ActionResult Index() {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
    }
}