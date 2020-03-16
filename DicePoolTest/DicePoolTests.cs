using NUnit.Framework;

namespace DicePoolTest
{
    [TestFixture]
    public class DicePoolTests
    {
        [Test]
        public void AddNumericDie()
        {
            var testPool = new DicePool.DicePool("test pool");
            var dice = testPool.AddDie(6, "test die", 2);
            
            Assert.AreEqual(2, dice.Count);
        }
    }
}