using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeSolutions.NeetCode.AnagramGroup.Tests
{
    [TestClass()]
    public class GroupAnagramTests
    {
        [TestMethod()]
        public void GroupAnagramsTest()
        {
            List<List<string>> result = GroupAnagram.GroupAnagrams(new string[] { "act", "pots", "tops", "cat", "stop", "hat" });

            List<List<string>> expectedResult = new List<List<string>>() {
                new List<string>(){"act", "cat"},
                new List<string>(){"hat"},
                new List<string>(){ "stop", "pots", "tops" }
                };

            result.Should().BeEquivalentTo(expectedResult);
        }

        [TestMethod()]
        public void GroupAnagramsSingleTest()
        {
            List<List<string>> result = GroupAnagram.GroupAnagrams(new string[] { "" });

            List<List<string>> expectedResult = new List<List<string>>() {
                new List<string>(){""}
                };

            result.Should().BeEquivalentTo(expectedResult);
        }

        [TestMethod()]
        public void GroupAnagramsSingleXTest()
        {
            List<List<string>> result = GroupAnagram.GroupAnagrams(new string[] { "X" });

            List<List<string>> expectedResult = new List<List<string>>() {
                new List<string>(){"X"}
                };

            result.Should().BeEquivalentTo(expectedResult);
        }


        [TestMethod()]
        public void GroupAnagramsSingleNullTest()
        {
            List<List<string>> result = GroupAnagram.GroupAnagrams(new string[] { });

            List<List<string>> expectedResult = new List<List<string>>() { };

            result.Should().BeEquivalentTo(expectedResult);
        }
    }
}