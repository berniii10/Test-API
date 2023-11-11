using Project1.Application;
using Project1.Application.Http;
using System;

namespace Project1
{
    class Program
    { 
        static void Main(string[] args)
        {
            Controller controller = new Controller();
            controller.myMain();
            Console.ReadLine();
        }
    }
}
