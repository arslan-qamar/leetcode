using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;

namespace Last_Stone_Weight.Tests
{
    [TestClass()]
    public class LastStoneWeightFinderTests
    {
        [TestMethod()]
        public void LastStoneWeightTest()
        {
            LastStoneWeightFinder.LastStoneWeight(new int[] { 2, 3, 6, 2, 4 }).Should().Be(1);
        }


        [TestMethod()]
        public void LastStoneWeightTest2()
        {
            LastStoneWeightFinder.LastStoneWeight(new int[] { 1, 2 }).Should().Be(1);
        }


        [TestMethod()]
        public void LastStoneWeightTest3()
        {
            LastStoneWeightFinder.LastStoneWeight(new int[] { 2, 2 }).Should().Be(0);
        }
    }
}