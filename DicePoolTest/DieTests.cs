using System.Collections.Generic;
using DicePool;
using NUnit.Framework;

namespace DicePoolTest
{
    public class DieTests
    {
        [Test]
        public void CreateNumericDie()
        {
            var testDie = new Die(6);
            
            Assert.AreEqual("6sided", testDie.Name);
            var expectedFacets = new List<string>{"1", "2", "3", "4", "5", "6"};
            Assert.AreEqual(expectedFacets, testDie.Facets);
        }
    }
}