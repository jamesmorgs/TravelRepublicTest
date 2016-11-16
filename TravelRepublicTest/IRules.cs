using System;
using System.Collections.Generic;

namespace TravelRepublic.FlightCodingTest
{
    public interface IRules
    {
        IList<Func<Flight, bool>> RulesList { get; }
    }
}
