using System.Web.Mvc;

namespace HotelWebApp.Controllers
{
    public class SPAController : Controller
    {
        // GET: SPA
        public ActionResult Index()
        {
            string srcType = "text/html";
            string srcPath = "~/SPA/src/index.html";

            return File(srcPath, srcType);
        }
    }
}