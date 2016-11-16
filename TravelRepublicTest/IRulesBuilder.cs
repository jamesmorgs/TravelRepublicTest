using System;
using System.Collections.Generic;

namespace TravelRepublic.FlightCodingTest
{
    public interface IRulesBuilder
    {
        IList<Func<Flight, bool>> Rules { get; set; }
    }
}
