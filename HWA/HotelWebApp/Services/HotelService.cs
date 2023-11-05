using HotelWebApp.Models.Responses;
using HotelWebApp.Utilities;
using HotelWebApp.Models;

using System;
using System.Linq;
using System.Text;
using System.Net.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace HotelWebApp.Services
{
    public class HotelService
    {
        static readonly HttpClient httpClient = new HttpClient();

        /// <summary>
        /// - GET REGION RESULTS FROM SEARCH.
        /// </summary>
        /// <returns></returns>
        public static async Task<string> GetRegionId(HotelRequest model)
        {
            try
            {
                httpClient.DefaultRequestHeaders.Clear();
                httpClient.DefaultRequestHeaders.Add("X-RapidAPI-Host", AppSettings.RapidAPIHost);
                httpClient.DefaultRequestHeaders.Add("X-RapidAPI-Key", System.Configuration.ConfigurationManager.AppSettings["RapidAPIKey"]);

                HttpResponseMessage response = await httpClient.GetAsync($"{AppSettings.APIURL}locations/v3/search?q={model.Location}");
                if (response.IsSuccessStatusCode)
                {
                    string result = await response.Content.ReadAsStringAsync();
                    SearchResponse searchResponse = JsonConvert.DeserializeObject<SearchResponse>(result);
                    return searchResponse.Hotels.FirstOrDefault().gaiaId;
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
        public static async Task<List<Hotel>> GetHotelData(HotelRequest model)
        {
            try
            {
                httpClient.DefaultRequestHeaders.Clear();
                HttpRequestMessage requestMessage = new HttpRequestMessage();

                var regionId = await GetRegionId(model);
                if (regionId == null)
                {
                    return null;
                }

                model.destination = new Destination { regionId = regionId };

                //UriBuilder uriBuilder = new UriBuilder($"https://hotels4.p.rapidapi.com/properties/v2/list");
                UriBuilder uriBuilder = new UriBuilder($"{AppSettings.APIURL}properties/v2/list");
                List<Property> properties = new List<Property>();

                if (model != null)
                {
                    string json = JsonConvert.SerializeObject(model);
                    requestMessage.Content = new StringContent(json, Encoding.UTF8, "application/json");
                }

                requestMessage.Method = HttpMethod.Post;
                requestMessage.RequestUri = uriBuilder.Uri;
                requestMessage.Headers.Add("X-RapidAPI-Key", System.Configuration.ConfigurationManager.AppSettings["RapidAPIKey"]);
                requestMessage.Headers.Add("X-RapidAPI-Host", AppSettings.RapidAPIHost);

                List<Hotel> hotels = new List<Hotel>();
                HttpResponseMessage result = await httpClient.SendAsync(requestMessage);
                if (result.IsSuccessStatusCode)
                {
                    string response = await result.Content.ReadAsStringAsync();
                    properties = JsonConvert.DeserializeObject<LocationResponse>(response).data.propertySearch.properties;

                    foreach (Property property in properties)
                    {
                        Hotel hotel = new Hotel
                        {
                            Id = Int32.Parse(property.id),
                            Name = property.name,
                            Price = property.price.lead.amount,
                            Image = property.propertyImage.image.url.ToString(),
                            Available = property.availability.available,
                            RegionId = double.Parse(property.destinationInfo.regionId)
                        };
                        if (!(hotels.Any(h => h.Id == hotel.Id)))
                        {
                            hotels.Add(hotel);
                        }
                    }
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