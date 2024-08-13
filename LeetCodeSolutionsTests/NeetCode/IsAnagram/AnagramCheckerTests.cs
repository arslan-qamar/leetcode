using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeSolutions.NeetCode.IsAnagram.Tests
{
    [TestClass()]
    public class AnagramCheckerTests
    {

        [TestMethod()]
        public void IsAnagramTest()
        {
            Assert.IsTrue(AnagramChecker.IsAnagram("racecar", "carrace"));
        }


        [TestMethod()]
        public void IsNotAnagramTest()
        {
            Assert.IsFalse(AnagramChecker.IsAnagram("jar", "jam"));
        }

    }
}