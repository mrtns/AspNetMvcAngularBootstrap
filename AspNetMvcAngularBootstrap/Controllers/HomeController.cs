using System.Web.Mvc;

namespace YeomanAngularBootstrapMvc4.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index() {
            return View();
        }

        public ActionResult Home() {
            return PartialView();
        }

        public ActionResult About() {
            return PartialView();
        }

        public ActionResult Contact() {
            return PartialView();
        }
    }
}