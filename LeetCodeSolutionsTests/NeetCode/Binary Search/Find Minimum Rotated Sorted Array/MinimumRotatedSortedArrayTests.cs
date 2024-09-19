using FluentAssertions;

namespace Binary_Search.Find_Minimum_Rotated_Sorted_Array.Tests
{
    [TestClass()]
    public class MinimumRotatedSortedArrayTests
    {
        [TestMethod()]
        public void FindMinTest()
        {
            _ = MinimumRotatedSortedArray.FindMin(new int[] { 3, 4, 5, 6, 1, 2 }).Should().Be(1);
        }

        [TestMethod()]
        public void FindMinTest2()
        {
            _ = MinimumRotatedSortedArray.FindMin(new int[] { 3 }).Should().Be(3);
        }


        [TestMethod()]
        public void FindMinTest3()
        {
            _ = MinimumRotatedSortedArray.FindMin(new int[] { 4, 5, 0, 1, 2, 3 }).Should().Be(0);
        }


        [TestMethod()]
        public void FindMinTest4()
        {
            _ = MinimumRotatedSortedArray.FindMin(new int[] { 4, 5, 6, 7 }).Should().Be(4);
        }

        [TestMethod()]
        public void FindMinTest5()
        {
            _ = MinimumRotatedSortedArray.FindMin(new int[] { 1, 2 }).Should().Be(1);
        }

    }
}