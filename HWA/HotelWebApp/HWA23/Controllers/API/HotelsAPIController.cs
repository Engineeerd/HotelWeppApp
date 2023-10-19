using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;

using HWA23.Services;
using HWA23.Models;
using System;
using System.Net.Http;

namespace HWA23.Controllers.API
{
    [RoutePrefix("api/hotels")]
    public class HotelsAPIController : ApiController
    {
        [HttpPost]
        [Route("search")]
        public async Task<HttpResponseMessage> Search(HotelRequestData model)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateResponse(ModelState);
            }

            // Date String to Date Object.
            DateTime from = DateTime.Parse(model.CheckIn);
            DateTime to = DateTime.Parse(model.CheckOut);
            model.checkInDate = new CheckInDate
            {
                day = from.Day,
                month = from.Month,
                year = from.Year
            };
            model.checkOutDate = new CheckOutDate
            {
                day = to.Day,
                month = to.Month,
                year = to.Year
            };
            model.rooms = new List<Room>
                {
                    new Room
                    {
                        adults = 1,
                        children = new List<Child>()
                    }
                };
            model.resultsStartingIndex = 0;
            model.resultsSize = 25;

            List<Hotel> response = await HotelService.GetHotelData(model);
            if (response == null)
            {
                return Request.CreateResponse(System.Net.HttpStatusCode.NotFound);
            }
            return Request.CreateResponse(System.Net.HttpStatusCode.OK, response);
        }
    }
}
