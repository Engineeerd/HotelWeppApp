using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;
using System.Web.Http;
using System.Net;

using HWA23.Services;
using System.Linq;
using HWA.Models;

namespace HWA23.Controllers.API
{
    [RoutePrefix("api/hotels")]
    public class HotelsAPIController : ApiController
    {
        [Route("countries"), HttpGet]
        public async Task<Countries> Countries()
        {
            Countries response = await HotelService.GetMetaData();

            return response;
        }

        [Route("searchHotels"), HttpGet]
        public async Task<List<Sr>> SearchHotels(string location)
        {
            List<Sr> response = await HotelService.GetAll(location);

            return response;
        }

        [Route("search"), HttpGet]
        public async Task<List<Sr>> Search(string location)
        {
            List<Sr> response = await HotelService.GetAll(location);

            return response;
        }
    }
}