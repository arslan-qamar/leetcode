using FluentAssertions;

namespace Minimum_Window_With_Characters
{
    [TestClass()]
    public class MinimumWindowWithCharactersTests
    {
        [TestMethod()]
        public void MinWindowTest()
        {
            _ = MinimumWindowWithCharacters.MinWindow("OUZODYXAZV", "XYZ").Should().Be("YXAZ");
        }

        [TestMethod()]
        public void MinWindowSpecialCaseTest()
        {
            _ = MinimumWindowWithCharacters.MinWindow("a", "a").Should().Be("a");
        }
    }
}