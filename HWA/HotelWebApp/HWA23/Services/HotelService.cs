using HWA23.Utilities;
using HWA23.Models;

using Newtonsoft.Json;

using System;
using System.Linq;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace HWA23.Services
{
    public class HotelService
    {
        /// <summary>
        /// - SETS THE HTTP CLIENT AND HEADERS.
        /// </summary>
        /// <returns></returns>
        public static HttpClient SetClient()
        {
            HttpClient httpClient = new HttpClient();

            httpClient.DefaultRequestHeaders.Clear();
            httpClient.DefaultRequestHeaders.Add("X-RapidAPI-Host", AppSettings.RapidAPIHost);
            httpClient.DefaultRequestHeaders.Add("X-RapidAPI-Key", AppSettings.RapidAPIKey);

            return httpClient;
        }

        /// <summary>
        /// - GENERATES THE URL FOR THE API.
        /// </summary>
        /// <param name="location"></param>
        /// <returns></returns>
        private static string GetUrl(string route, string data)
        {
            data = (data == null) ? "" : data;
            return new StringBuilder(AppSettings.APIURL + route + data, 256).ToString();
        }

        /// <summary>
        /// - GET REGION RESULTS FROM SEARCH.
        /// </summary>
        /// <returns></returns>
        public static async Task<string> GetRegionId(string location)
        {
            try
            {
                HttpClient httpClient = SetClient();
                HttpResponseMessage response = await httpClient.GetAsync(GetUrl("locations/v3/search?q=", location));
                if (response.IsSuccessStatusCode)
                {
                    string result = await response.Content.ReadAsStringAsync();
                    SearchResponse searchResponse = JsonConvert.DeserializeObject<SearchResponse>(result);
                    return searchResponse.sr.FirstOrDefault().gaiaId;
                }
            }
            catch (HttpRequestException e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
            }
            return null;
        }

        /// <summary>
        /// - GET FILTER HOTELS BY LOCATION AND CHECK IN CHECK OUT DATE.
        /// </summary>
        /// <returns></returns>
        public static async Task<List<Property>> GetHotelData(string location, string checkIn = "2023/12/01", string checkOut = "2023/12/12")
        {
            try
            {
                HttpClient httpClient = new HttpClient();
                httpClient.DefaultRequestHeaders.Clear();

                HttpRequestMessage requestMessage = new HttpRequestMessage();

                // Date String to Date Object.
                DateTime from = DateTime.Parse(checkIn);
                DateTime to = DateTime.Parse(checkOut);

                // Request Data Object.
                HotelRequestData requestData = new HotelRequestData();
                requestData.destination = new Destination { regionId = await GetRegionId(location) };
                requestData.checkInDate = new CheckInDate
                {
                    day = from.Day,
                    month = from.Month,
                    year = from.Year
                };
                requestData.checkOutDate = new CheckOutDate
                {
                    day = to.Day,
                    month = to.Month,
                    year = to.Year
                };
                requestData.rooms = new List<Room>
                {
                    new Room
                    {
                        adults = 2,
                        children = new List<Child>()
                    }
                };

                UriBuilder uriBuilder = new UriBuilder("https://hotels4.p.rapidapi.com/properties/v2/list");
                List<Property> hotels = new List<Property>();

                if (requestData != null)
                {
                    string json = JsonConvert.SerializeObject(requestData);
                    requestMessage.Content = new StringContent(json, Encoding.UTF8, "application/json");
                }

                requestMessage.Method = HttpMethod.Post;
                requestMessage.RequestUri = uriBuilder.Uri;
                requestMessage.Headers.Add("X-RapidAPI-Key", AppSettings.RapidAPIKey);
                requestMessage.Headers.Add("X-RapidAPI-Host", AppSettings.RapidAPIHost);

                HttpResponseMessage result = await httpClient.SendAsync(requestMessage);
                if (result.IsSuccessStatusCode)
                {
                    string response = await result.Content.ReadAsStringAsync();
                    hotels = JsonConvert.DeserializeObject<Root2>(response).data.propertySearch.properties;
                }
                return hotels;
            }
            catch (HttpRequestException e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
            }
            return null;
        }
    }
}
