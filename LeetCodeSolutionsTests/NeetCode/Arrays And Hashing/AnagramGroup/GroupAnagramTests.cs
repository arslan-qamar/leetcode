using FluentAssertions;

namespace AnagramGroup
{
    [TestClass()]
    public class GroupAnagramTests
    {
        [TestMethod()]
        public void GroupAnagramsTest()
        {
            List<List<string>> result = GroupAnagram.GroupAnagrams(new string[] { "act", "pots", "tops", "cat", "stop", "hat" });

            List<List<string>> expectedResult = [
                ["act", "cat"],
                ["hat"],
                ["stop", "pots", "tops"]
                ];

            _ = result.Should().BeEquivalentTo(expectedResult);
        }

        [TestMethod()]
        public void GroupAnagramsSingleTest()
        {
            List<List<string>> result = GroupAnagram.GroupAnagrams(new string[] { "" });

            List<List<string>> expectedResult = [
                [""]
                ];

            _ = result.Should().BeEquivalentTo(expectedResult);
        }

        [TestMethod()]
        public void GroupAnagramsSingleXTest()
        {
            List<List<string>> result = GroupAnagram.GroupAnagrams(new string[] { "X" });

            List<List<string>> expectedResult = [
                ["X"]
                ];

            _ = result.Should().BeEquivalentTo(expectedResult);
        }


        [TestMethod()]
        public void GroupAnagramsSingleNullTest()
        {
            List<List<string>> result = GroupAnagram.GroupAnagrams(new string[] { });

            List<List<string>> expectedResult = [];

            _ = result.Should().BeEquivalentTo(expectedResult);
        }
    }
}