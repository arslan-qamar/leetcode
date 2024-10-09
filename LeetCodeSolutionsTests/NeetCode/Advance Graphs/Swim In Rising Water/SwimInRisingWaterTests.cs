using FluentAssertions;

namespace Advance_Graphs.Swim_In_Rising_Water.Tests
{
    [TestClass()]
    public class SwimInRisingWaterTests
    {
        [TestMethod()]
        public void SwimInWaterTest()
        {
            SwimInRisingWater swm = new SwimInRisingWater();
            swm.SwimInWater([
                              [0,1,2,10],
                              [9,14,4,13],
                              [12,3,8,15],
                              [11,5,7,6]]).Should().Be(8);
            
        }

        [TestMethod()]
        public void SwimInWaterTest2()
        {
            SwimInRisingWater swm = new SwimInRisingWater();
            swm.SwimInWater([[0, 1], [2, 3]]).Should().Be(3);

        }
    }
}