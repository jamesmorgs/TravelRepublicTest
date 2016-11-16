using System;
using System.Collections.Generic;

namespace TravelRepublic.FlightCodingTest
{
    public class RulesBuilder : IRulesBuilder
    {    
        public RulesBuilder(IRules rules)
        {
            Rules = rules.RulesList;            
        }       

        public IList<Func<Flight, bool>> Rules { get; set; }
    }
}
