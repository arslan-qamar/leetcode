using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeSolutions.NeetCode.Product_Exclude_Self.Tests
{
    [TestClass()]
    public class ProductExcludeSelfTests
    {
        [TestMethod()]
        public void ProductExceptSelfTest()
        {
            int[] result = ProductExcludeSelf.ProductExceptSelf(new int[] { 1, 2, 4, 6 });

            int[] expectedResult = new int[] { 48, 24, 12, 8 };

            result.Should().BeEquivalentTo(expectedResult, options => options.WithStrictOrdering());
        }

        [TestMethod()]
        public void ProductExceptSelfTestWithZeroNegative()
        {
            int[] result = ProductExcludeSelf.ProductExceptSelf(new int[] { -1, 0, 1, 2, 3 });

            int[] expectedResult = new int[] { 0, -6, 0, 0, 0 };

            result.Should().BeEquivalentTo(expectedResult, options => options.WithStrictOrdering());
        }
    }
}