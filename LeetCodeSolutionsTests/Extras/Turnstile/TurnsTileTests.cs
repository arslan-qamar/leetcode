using FluentAssertions;

namespace Extras.Test_3.Tests
{
    [TestClass()]
    public class TurnsTileTests
    {
        [TestMethod()]
        public void getTimesTest()
        {

            _ = TurnsTile.getTimes2(
                [
                    0,0,1,5
                ],
                [
                    0,1,1,0
                ]
                ).Should().BeEquivalentTo(
                new List<int>() { 2, 0, 1, 5 }
                );
        }
    }
}