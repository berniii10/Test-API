using Project1.Application.Http;
using System;

namespace Project1
{
    class Program
    {
        // Method needs to be async if we are going to use await.
        static async void MyMain()
        {
            // Class to make HTTP requests
            HttpRequest htppRequest = new HttpRequest();
            string responseToHttpRequest = await htppRequest.request("linies/");
            if (responseToHttpRequest != null)
            {
                Console.WriteLine(responseToHttpRequest);
            }
            else 
            { 
                Console.WriteLine("Error"); 
            }
        }
        static void Main(string[] args)
        {
            MyMain();
            Console.ReadLine();
        }
    }
}
