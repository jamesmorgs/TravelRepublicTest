using System;
using System.Collections.Generic;
using System.Linq;

namespace TravelRepublic.FlightCodingTest
{
    public class Rules : IRules
    {
        static Func<Flight, bool> rule1 = f => f.Segments.Where(seg => seg.DepartureDate < DateTime.Now).Count() > 0;
        static Func<Flight, bool> rule2 = f => f.Segments.Where(seg => seg.ArrivalDate < seg.DepartureDate).Count() > 0;
        static Func<Flight, bool> rule3 = delegate (Flight flight)
        {
            bool filterOut = false;

            if (flight != null && flight.Segments != null)
            {
                IList<Segment> segmentsIn = flight.Segments;                

                for (int i = 1; i < segmentsIn.Count; i++)
                {
                    if ((segmentsIn[i].DepartureDate.Hour - segmentsIn[--i].ArrivalDate.Hour) >= 2)
                    {
                        filterOut = true;
                        break;
                    }
                    i++;
                }
            }            

            return filterOut;
        };

        public IList<Func<Flight, bool>> RulesList
        {
            get { return new List<Func<Flight, bool>>() { rule1, rule2, rule3 }; }
        }
    }
}
