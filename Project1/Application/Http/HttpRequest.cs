using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Project1.Application.Http
{
    static public class HttpRequest
    {
        static public async Task<string> request(string entity)
        {
            HttpClient client = new HttpClient();
            string URL_Base = "https://api.tmb.cat/v1/transit/";
            string URL_Parameters = "?app_id=7cdac919&app_key=abfd7135dd550a2945935fc28a1caf8e";
            try
            {
                HttpResponseMessage response = await client.GetAsync(URL_Base + entity + URL_Parameters);
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
