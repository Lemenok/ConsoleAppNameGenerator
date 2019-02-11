using System;
using System.Collections.Generic;
using System.Text;

namespace WebSiteGenerator.Models
{
    public static class GenerateWebsiteNames
    {
        public static List<string> GetListOfWebsites()
        {
            return GetWebsites();
        }

        private static List<string> GetWebsites()
        {
            List<string> listOfWebsiteNames = new List<string>();
            string newWebsite = string.Empty;

            // Get our List of Domain Names to build our website.
            Domains domains = new Domains();

            Random randomNumber = new Random();
            int websiteWordLength;
            int domainNumber;
            int TLDNumber;

            // Generate 10 Websites
            for(int i = 0; i < 10; i++)
            {
                // Reset our newWebsite string
                newWebsite = string.Empty;

                // Each Website is built between 2 or 3 words
                websiteWordLength = randomNumber.Next(2, 4);

                // For Each word 
                for(int k = 0; k < websiteWordLength; k++)
                {
                    // Generate a random word for the website.
                    domainNumber = randomNumber.Next(0, domains.GetRemainingDomainAmount());
                    newWebsite += $"{domains.GetNewDomain(domainNumber)}";

                    //If we are not the last word in the domain we want to add a '-'
                    if(websiteWordLength - 1 != k)
                    {
                        newWebsite += "-";
                    }
                }

                // Generate a random Top level domain for the website.
                TLDNumber = randomNumber.Next(0, 4);
                newWebsite += $"{domains.GetTopLevelDomain(TLDNumber)}";

                // Add the new website to the list.
                listOfWebsiteNames.Add(newWebsite);
            }

            return listOfWebsiteNames;
        }
    }
}
