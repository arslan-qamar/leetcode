using FluentAssertions;

namespace K_Closest_Points.Tests
{
    [TestClass()]
    public class KClosestPointsTests
    {
        [TestMethod()]
        public void KClosestTest()
        {
            _ = KClosestPoints.KClosest(new int[][]
            {
                new int[]{0,2 },
                new int[] {2,2 }

            }, 1).Should().BeEquivalentTo(new int[][]
            {
                new int[]{ 0 , 2}
            });
        }

        [TestMethod()]
        public void KClosestTest2()
        {
            _ = KClosestPoints.KClosest(new int[][]
            {
                new int[]{0,2 },
                new int[] {2,0 },
                new int[] {2,2 }

            }, 2).Should().BeEquivalentTo(new int[][]
            {
                new int[]{ 0 , 2},
                new int[]{ 2 , 0}
            });
        }

    }
}