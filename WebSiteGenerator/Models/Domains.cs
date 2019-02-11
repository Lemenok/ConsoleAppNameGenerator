using System;
using System.Collections.Generic;
using System.Text;

namespace WebSiteGenerator.Models
{
    public class Domains
    {
        private List<string> _DomainNames;
        private List<string> _TopLevelDomains;

        public Domains()
        {
            _DomainNames = GenerateDomainList();
            _TopLevelDomains = GenerateTopLevelDomains();
        }

        public string GetNewDomain(int domainNumber)
        {
            // Get the Domain from the list
            string domainName = _DomainNames[domainNumber];

            // Remove the domain so duplicates do not happen.
            _DomainNames.Remove(domainName);

            return domainName;
        }

        public int GetRemainingDomainAmount()
        {
            return _DomainNames.Count;
        }

        public string GetTopLevelDomain(int TLDNumber)
        {
            return _TopLevelDomains[TLDNumber];
        }

        private List<string> GenerateDomainList()
        {
            List<string> listOfDomains = new List<string>
            {
                "train",
                "frame",
                "feigned",
                "sour",
                "greasy",
                "mouse",
                "goose",
                "intelligent",
                "toothbrush",
                "zonked",
                "bread",
                "fetch",
                "imminent",
                "kite",
                "land",
                "ferry",
                "roof",
                "lyric",
                "aldreary",
                "aboard",
                "convince",
                "leaf",
                "materialistic",
                "tree",
                "sack",
                "humor",
                "enchanted",
                "tidy",
                "wander",
                "near",
                "scan",
                "trampl",
                "dinner",
                "respect",
                "ignore",
                "voice",
                "real",
                "park",
                "card",
                "flippant"
            };

            return listOfDomains;
        }

        private List<string> GenerateTopLevelDomains()
        {
            List<string> listOfTLDs = new List<string>
            {
                ".com",
                ".net",
                ".org",
                ".gov"
            };

            return listOfTLDs;
        }
    }
}
