using FluentAssertions;
using LeetCodeSolutions.NeetCode.Graphs.Ladder_Length;

namespace Ladder_Length.Tests
{
    [TestClass()]
    public class LadderLengthFinderTests
    {
        [TestMethod()]
        public void LadderLengthTest()
        {
            LadderLengthFinder lf = new LadderLengthFinder();

            lf.LadderLength("cat", "sag", ["bat", "bag", "sag", "dag", "dot"]).Should().Be(4);

        }

        [TestMethod()]
        public void LadderLengthTestNeedCodeFail()
        {
            LadderLengthFinder lf = new LadderLengthFinder();

            lf.LadderLength("cat", "sag", ["bat", "bag", "sat", "dag", "dot"]).Should().Be(0);

        }
    }
}