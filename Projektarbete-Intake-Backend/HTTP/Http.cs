using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Projektarbete_Intake_Backend.HTTP
{
    public class Http : ControllerBase
    {
        private static readonly string foodApi = "https://trackapi.nutritionix.com/v2/search/instant?self=false&query=";
        private static readonly string appId = "ca743281";
        private static readonly string appKey = "8de9ae6cf37d39687a6d06b48fe45c07";

        public async static Task<string> Search(string query)
        {
            string searchQuery = foodApi + query;
            try
            {
                // Using HttpClient to make call
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("x-app-id", appId);
                    client.DefaultRequestHeaders.Add("x-app-key", appKey);

                    // Fetching data
                    using (HttpResponseMessage res = await client.GetAsync(searchQuery))
                    {
                        
                        // Getting data from response
                        using (HttpContent content = res.Content)
                        {
                            // Convert to string and return
                            return await content.ReadAsStringAsync();
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                return null;
            }
        }
    }
}
