using HotelWebApp.Services;
using HotelWebApp.Models;

using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace HotelWebApp.Controllers.API
{
    [RoutePrefix("api/hotels")]
    public class HotelsAPIController : ApiController
    {
        [HttpPost]
        [Route("search")]
        public async Task<HttpResponseMessage> Search(HotelRequest model)
        {
            if (System.Configuration.ConfigurationManager.AppSettings["RapidAPIKey"] == null)
            {
                return Request.CreateResponse(HttpStatusCode.Unauthorized);
            }

            if (!ModelState.IsValid)
            {
                return Request.CreateResponse(ModelState);
            }

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

            List<Hotel> hotels = await HotelService.GetHotelData(model);
            if (hotels == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

            return Request.CreateResponse(HttpStatusCode.OK, hotels);
        }
    }
}
