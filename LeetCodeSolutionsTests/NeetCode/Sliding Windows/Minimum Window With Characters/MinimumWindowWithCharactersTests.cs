using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeSolutions.NeetCode.Minimum_Window_With_Characters.Tests
{
    [TestClass()]
    public class MinimumWindowWithCharactersTests
    {
        [TestMethod()]
        public void MinWindowTest()
        {
            MinimumWindowWithCharacters.MinWindow("OUZODYXAZV", "XYZ").Should().Be("YXAZ");
        }

        [TestMethod()]
        public void MinWindowSpecialCaseTest()
        {
            MinimumWindowWithCharacters.MinWindow("a", "a").Should().Be("a");
        }
    }
}