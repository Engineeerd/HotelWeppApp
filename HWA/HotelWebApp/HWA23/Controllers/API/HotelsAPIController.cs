using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;

using HWA23.Services;
using HWA23.Models;

namespace HWA23.Controllers.API
{
    [RoutePrefix("api/hotels")]
    public class HotelsAPIController : ApiController
    {
        [HttpGet]
        [Route("search")]
        public async Task<List<Property>> Search(string location)
        {
            List<Property> response = await HotelService.GetHotelData(location);
            return response;
        }
    }
}
