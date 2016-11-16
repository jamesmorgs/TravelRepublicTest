using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace TravelRepublic.FlightCodingTest.Tests
{
    [TestClass()]
    public class RulesBuilderTests
    {
        RulesBuilder _rulesBuilder;

        [TestInitialize]
        public void SetUp()
        {
            _rulesBuilder = new RulesBuilder(new Rules());
        }

        [TestMethod()]
        public void RulesBuilderTest()
        {
            IList<Func<Flight, bool>> rules = _rulesBuilder.Rules;
            Assert.IsNotNull(rules);
            Assert.AreEqual(rules.Count, 3);
        }
    }
}