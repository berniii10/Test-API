using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Project1.Application.Http
{
    public class HttpRequest
    {
        private const string URL_Base = "https://api.tmb.cat/v1/transit/";
        private string URL_Parameters = "?app_id=7cdac919&app_key=abfd7135dd550a2945935fc28a1caf8e";

        public async Task<string> request(string URL_Data)
        {
            HttpClient client = new HttpClient();

            try
            {
                HttpResponseMessage response = await client.GetAsync(URL_Base + URL_Data + URL_Parameters);
                if (response.IsSuccessStatusCode)
                {
                    // Read and display the response content
                    string responseContent = await response.Content.ReadAsStringAsync();
                    return responseContent;
                }
                else
                {
                    Console.WriteLine($"API request failed with status code: {response.StatusCode}");
                    return null;
                }
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine($"API request error: {e.Message}");
                return null;
            }
        }
    }
}
