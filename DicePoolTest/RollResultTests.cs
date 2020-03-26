using System.Collections.Generic;
using DicePool;
using NUnit.Framework;

namespace DicePoolTest
{
    public class RollResultTests
    {
        [Test]
        public void TestGetIntResults()
        {
            var rollResult = new RollResult();
            rollResult.AddResult("6sided", "1");
            rollResult.AddResult("6sided", "4");
            rollResult.AddResult("6sided", "2");

            var intResults = rollResult.GetIntResults();

            var expectedResults = new List<int>() {1, 4, 2};
            Assert.AreEqual(expectedResults, intResults);
        }
    }
}