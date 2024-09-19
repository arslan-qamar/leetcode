using FluentAssertions;

namespace Binary_Search
{
    [TestClass()]
    public class BinarySearchTests
    {
        [TestMethod()]
        public void SearchTest()
        {
            _ = BinarySearch.Search(new int[] { -1, 0, 2, 4, 6, 8 }, 4).Should().Be(3);
            _ = BinarySearch.Search(new int[] { -1, 0, 2, 4, 6, 8 }, 3).Should().Be(-1);
        }

        [TestMethod()]
        public void SearchTestSpecial()
        {
            _ = BinarySearch.Search(new int[] { -1, 0, 3, 5, 9, 12 }, 9).Should().Be(4);
        }
    }
}