using System.Collections.Generic;
using System.Web.Mvc;
using System.Linq;
using System.Web;
using System;

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