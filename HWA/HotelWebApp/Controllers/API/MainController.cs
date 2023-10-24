using System.Web.Http;

namespace HotelWebApp.Controllers.API
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
