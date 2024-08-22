using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Top_K_Frequent
{
    [TestClass()]
    public class TopKFrequentFinderTests
    {
        [TestMethod()]
        public void TopKFrequentTest()
        {
            int[] result = TopKFrequentFinder.TopKFrequent(new int[] { 1, 2, 2, 3, 3, 3 }, 2);

            result.Should().BeEquivalentTo(new int[] { 2, 3 });
        }

        [TestMethod()]
        public void TopKFrequentTestRepeat7()
        {
            int[] result = TopKFrequentFinder.TopKFrequent(new int[] { 7, 7, 7 }, 1);

            result.Should().BeEquivalentTo(new int[] { 7 });
        }


        [TestMethod()]
        public void TopKFrequentTest12()
        {
            int[] result = TopKFrequentFinder.TopKFrequent(new int[] { 1, 2 }, 2);

            result.Should().BeEquivalentTo(new int[] { 1, 2 });
        }

        [TestMethod()]
        public void TopKFrequentTest123456789()
        {
            int[] result = TopKFrequentFinder.TopKFrequent(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 2);

            result.Should().BeEquivalentTo(new int[] { 1, 2 });
        }
    }
}