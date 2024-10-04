using FluentAssertions;

namespace LeetCodeSolutions.NeetCode.Bit_Manipulation.Missing_Number.Tests
{
    [TestClass()]
    public class MissingNumberFinderTests
    {
        [TestMethod()]
        public void MissingNumberTest()
        {
            MissingNumberFinder mf = new MissingNumberFinder();

            mf.MissingNumber([1, 2, 3]).Should().Be(0);
        }

        [TestMethod()]
        public void MissingNumberTest2()
        {
            MissingNumberFinder mf = new MissingNumberFinder();

            mf.MissingNumber([0, 2]).Should().Be(1);
        }

        [TestMethod()]
        public void MissingNumberTest3()
        {
            MissingNumberFinder mf = new MissingNumberFinder();

            mf.MissingNumber([1, 2]).Should().Be(0);
        }
    }

}