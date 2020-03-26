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

        [Test]
        public void CreateStringDie()
        {
            var testFacets = new List<string>() {"result1", "result2", "result3", "result4"};
            var testDie = new Die(testFacets, "Test Name");
            
            Assert.AreEqual("Test Name", testDie.Name);
            Assert.AreEqual(testFacets, testDie.Facets);
        }

        [Test]
        public void TestRoll()
        {
            var testDie = CreateTestNumericDie(6);
            var expectedResults = new List<string> {"1", "2", "3", "4", "5", "6"};

            var rollResult = testDie.Roll();
            
            Assert.IsTrue(expectedResults.Contains(rollResult));
        }

        private Die CreateTestNumericDie(int sides, string name = "")
        {
            return new Die(sides, name);
        }
    }
}