using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace TravelRepublic.FlightCodingTest.Tests
{
    [TestClass()]
    public class FlightBuilderTests
    {
        FlightBuilder _flightBuilder;

        [TestInitialize]
        public void SetUp()
        {
            _flightBuilder = new FlightBuilder();
        }

        [TestMethod()]
        public void GetFlightsTest()
        {
            IList<Flight> flights = _flightBuilder.GetFlights();

            Assert.AreEqual(flights.Count, 6);
        }
    }
}