using System.Web.Http;

namespace HotelWebApp.Controllers
{
    public class MainController : ApiController
    {
        [HttpGet]
        public string Get()
        {
            return "Hello World!";
        }
    }
}
