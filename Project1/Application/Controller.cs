using Project1.Application.Http;
using Project1.Application.Json;
using Project1.Application.TmbDataClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Application
{
    public class Controller
    {
        // Method needs to be async if we are going to use await.
        public async void myMain()
        {
            string responseToHttpRequest = await HttpRequest.request("linies/");
            if (responseToHttpRequest != null)
            {
                TmbData tmbData = JsonDeserializer.Deserialize(responseToHttpRequest);
                Console.WriteLine(responseToHttpRequest);
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}
