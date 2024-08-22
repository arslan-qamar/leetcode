using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;

namespace Three_Integer_Sum
{
    [TestClass()]
    public class ThreeIntegerSumTests
    {
        [TestMethod()]
        public void ThreeSumTest()
        {
            ThreeIntegerSum.ThreeSum(new int[] { -1, 0, 1, 2, -1, -4 }).ShouldBeEquivalentTo(new List<List<int>>()
            {
                new List<int>(){ -1,-1,2 },
                new List<int>() { -1, 0, 1 }
            });


            ThreeIntegerSum.ThreeSum(new int[] { 0, 1, 1 }).ShouldBeEquivalentTo(new List<List<int>>()
            {

            });


            ThreeIntegerSum.ThreeSum(new int[] { 0, 0, 0 }).ShouldBeEquivalentTo(new List<List<int>>()
            {
                new List<int>(){ 0,0,0 }
            });


        }

        [TestMethod()]
        public void SpecialCase()
        {
            ThreeIntegerSum.ThreeSum(new int[] { 0, 0, 0, 0 }).ShouldBeEquivalentTo(new List<List<int>>()
            {
                new List<int>(){ 0,0,0 }
            });
        }

        [TestMethod()]
        public void SpecialCase2()
        {
            ThreeIntegerSum.ThreeSum(new int[] { -2, 0, 1, 1, 2 }).ShouldBeEquivalentTo(new List<List<int>>()
            {
                new List<int>(){ -2,0,2 },
                new List<int>(){ -2, 1, 1 }
            });

        }

        [TestMethod()]
        public void SpecialCase3()
        {
            ThreeIntegerSum.ThreeSum(new int[] { 1, 2, -2, -1 }).ShouldBeEquivalentTo(new List<List<int>>()
            {

            });

        }

    }
}