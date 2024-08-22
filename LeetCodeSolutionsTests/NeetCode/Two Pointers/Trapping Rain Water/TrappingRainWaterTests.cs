using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Trapping_Rain_Water
{
    [TestClass()]
    public class TrappingRainWaterTests
    {
        [TestMethod()]
        public void TrapTest()
        {
            TrappingRainWater.Trap(new int[] { 0, 2, 0, 3, 1, 0, 1, 3, 2, 1 }).Should().Be(9);
        }
    }
}