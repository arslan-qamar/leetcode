using FluentAssertions;
using LeetCodeSolutions.NeetCode.Advance_Graphs.Alien_Dictionary;

namespace Alien_Dictionary.Tests
{
    [TestClass()]
    public class AlienDictionaryTests
    {
        [TestMethod()]
        public void foreignDictionaryTest()
        {
            AlienDictionary ad = new AlienDictionary();
            ad.foreignDictionary(["z", "o"]).Should().Be("zo");
        }

        [TestMethod()]
        public void foreignDictionaryTest2()
        {
            AlienDictionary ad = new AlienDictionary();
            ad.foreignDictionary(["hrn", "hrf", "er", "enn", "rfnn"]).Should().Be("hernf");
        }
    }
}