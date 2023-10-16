using HWA.Models;
using HWA23.Utilities;

using Newtonsoft.Json;

using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

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
        /// - SEARCHES FOR HOTELS.
        /// </summary>
        /// <returns></returns>
        public static async Task<List<Sr>> GetAll(string sendData)
        {
            try
            {
                HttpClient httpClient = SetClient();
                string url = AppSettings.APIURL + "locations/v3/search?q=" + sendData;

                var response = await httpClient.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    string result = await response.Content.ReadAsStringAsync();
                    SearchResponse tempResponse = JsonConvert.DeserializeObject<SearchResponse>(result);
                    return tempResponse.sr;
                }
                return null;
            }
            catch (HttpRequestException e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
            }
            return null;
        }

        /// <summary>
        /// - GET ALL COUNTRIES FROM META DATA.
        /// </summary>
        /// <returns></returns>
        public static async Task<Countries> SubmitData(string location)
        {
            try
            {
                HttpClient httpClient = SetClient();

                var anonymousObject = new
                {
                    destination = new { regionId = "6054439" },
                    checkInDate = new
                    {
                        day = 10,
                        month = 10,
                        year = 2022
                    },
                    checkOutDate = new
                    {
                        day = 15,
                        month = 10,
                        year = 2022
                    },
                    rooms = new[] {
                        new
                        {
                            adults = 2,
                            children = new[]
                            {
                                new { age = 5 },
                                new { age = 7 }
                            }
                        }
                    }
                };
                List<Sr> list = await GetAll(location);

                string url = AppSettings.APIURL + "properties/v2/list";
                HttpResponseMessage response = await httpClient.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<Countries>(result);
                }
            }
            catch (HttpRequestException e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
            }
            return null;
        }

        /// <summary>
        /// - GET ALL COUNTRIES FROM META DATA.
        /// </summary>
        /// <returns></returns>
        public static async Task<Countries> GetMetaData()
        {
            try
            {
                HttpClient httpClient = SetClient();

                string url = AppSettings.APIURL + "v2/get-meta-data";
                HttpResponseMessage response = await httpClient.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<Countries>(result);
                }
            }
            catch (HttpRequestException e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
            }
            return null;
        }
    }
}
