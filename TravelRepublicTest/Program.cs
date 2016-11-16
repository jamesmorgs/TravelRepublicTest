using System;
using System.Collections.Generic;
using System.Linq;

namespace TravelRepublic.FlightCodingTest
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<Flight> allFlights = GetAllFlights(new FlightBuilder());

            Console.WriteLine("This should show All flights!");
            ShowFlights(allFlights);
            Console.WriteLine();
                        
            FilterFlights(allFlights, new RulesBuilder(new Rules()));

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        private static IList<Flight> GetAllFlights(FlightBuilder flightBuilder)
        {
            return flightBuilder.GetFlights();
        }

        private static void FilterFlights(IList<Flight> flights, IRulesBuilder rulesBuilder)
        {
            var flightsFiltered = new List<Flight>();   

            if (rulesBuilder != null && rulesBuilder.Rules != null && flights.Count > 0)
            {
                foreach (var rule in rulesBuilder.Rules)
                {
                    flightsFiltered.AddRange(flights.Where(rule));
                }

                Console.WriteLine("This should show filtered out flights based on the rules!");
                ShowFlights(flightsFiltered);
            }            
        }

        private static void ShowFlights(IList<Flight> flights)
        {
            foreach (var flight in flights)
            {
                Console.WriteLine("flight :");

                foreach (var segment in flight.Segments)
                {                    
                    Console.WriteLine(string.Format("Segment: {0} - {1}", segment.DepartureDate.ToString(), segment.ArrivalDate.ToString()));
                }
            }
        }
    }
}
