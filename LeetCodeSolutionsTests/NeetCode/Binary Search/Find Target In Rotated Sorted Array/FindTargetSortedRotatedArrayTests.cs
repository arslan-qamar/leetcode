using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Binary_Search.Find_Target_In_Rotated_Sorted_Array.Tests
{
    [TestClass()]
    public class FindTargetSortedRotatedArrayTests
    {
        [TestMethod()]
        public void SearchTestBasic()
        {
            FindTargetSortedRotatedArray.Search(new int[] { 1, 2, 3, 4, 5, 6 }, 4).Should().Be(3);
        }

        [TestMethod()]
        public void SearchTest()
        {
            FindTargetSortedRotatedArray.Search(new int[] { 3, 4, 5, 6, 1, 2 }, 1).Should().Be(4);
        }

        [TestMethod()]
        public void SearchTest2()
        {
            FindTargetSortedRotatedArray.Search(new int[] { 3, 5, 6, 0, 1, 2 }, 4).Should().Be(-1);
        }

        [TestMethod()]
        public void SearchTest3()
        {
            FindTargetSortedRotatedArray.Search(new int[] { 1 }, 0).Should().Be(-1);
        }

        [TestMethod()]
        public void SearchTest4()
        {
            FindTargetSortedRotatedArray.Search(new int[] { 1, 3 }, 3).Should().Be(1);
        }


        [TestMethod()]
        public void SearchTest5()
        {
            FindTargetSortedRotatedArray.Search(new int[] { 5, 1, 2, 3, 4 }, 1).Should().Be(1);
        }
    }
}