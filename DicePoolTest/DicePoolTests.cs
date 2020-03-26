using DicePool;
using NUnit.Framework;

namespace DicePoolTest
{
    [TestFixture]
    public class DicePoolTests
    {
        [Test]
        public void TestAddNumericDie()
        {
            var testPool = new DicePool.DicePool("test pool");
            var dice = testPool.AddDie(6, "test die", 2);
            
            Assert.AreEqual(2, dice.Count);
        }

        [Test]
        public void TestRollPool()
        {
            var testPool = new DicePool.DicePool("test pool");
            testPool.AddDie(6, "test die", 2);

            var testResult = testPool.RollPool();
            
            Assert.IsInstanceOf<RollResult>(testResult);
        }
    }
}