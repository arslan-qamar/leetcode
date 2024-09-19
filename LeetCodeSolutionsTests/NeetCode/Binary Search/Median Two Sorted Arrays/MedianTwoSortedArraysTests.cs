using FluentAssertions;

namespace Binary_Search.Median_Two_Sorted_Arrays.Tests
{
    [TestClass()]
    public class MedianTwoSortedArraysTests
    {
        [TestMethod()]
        public void FindMedianSortedArraysTest()
        {
            _ = MedianTwoSortedArrays.FindMedianSortedArrays(new int[] { 1, 2 }, new int[] { 3 }).Should().Be(2.0);
        }

        [TestMethod()]
        public void FindMedianSortedArraysTest2()
        {
            _ = MedianTwoSortedArrays.FindMedianSortedArrays(new int[] { 1, 3 }, new int[] { 2, 4 }).Should().Be(2.5);
        }

        [TestMethod()]
        public void FindMedianSortedArraysTest3()
        {
            _ = MedianTwoSortedArrays.FindMedianSortedArrays(new int[] { 1, 3 }, new int[] { 2 }).Should().Be(2);
        }
    }
}