using FluentAssertions;

namespace Binary_Search.Eating_Bananas.Tests
{
    [TestClass()]
    public class EatingBananasTests
    {
        [TestMethod()]
        public void MinEatingSpeedTest()
        {
            _ = EatingBananas.MinEatingSpeed(new int[] { 1, 4, 3, 2 }, 9).Should().Be(2);
        }

        [TestMethod()]
        public void MinEatingSpeedTest2()
        {
            _ = EatingBananas.MinEatingSpeed(new int[] { 25, 10, 23, 4 }, 4).Should().Be(25);
        }
    }
}