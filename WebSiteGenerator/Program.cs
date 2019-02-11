using System;
using System.Collections.Generic;
using WebSiteGenerator.Models;

namespace WebSiteGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listOfWebsites = new List<string>();

            // Get Websites
            listOfWebsites = GenerateWebsiteNames.GetListOfWebsites();

            // Print Websites
            foreach(string website in listOfWebsites)
            {
                Console.WriteLine($"{website}");
            }

            Console.WriteLine("\nPress enter to close.");
            Console.ReadLine();
        }
    }
}
