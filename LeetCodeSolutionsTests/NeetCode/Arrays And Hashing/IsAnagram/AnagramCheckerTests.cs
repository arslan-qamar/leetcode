namespace IsAnagram
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