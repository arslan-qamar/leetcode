using FluentAssertions;

namespace Binary_Search.TimeMap.Tests
{
    [TestClass()]
    public class TimeMapTests
    {
        [TestMethod()]
        public void TimeMapTest()
        {
            TimeMap timeMap = new();
            timeMap.Set("alice", "happy", 1);  // store the key "alice" and value "happy" along with timestamp = 1.
            _ = timeMap.Get("alice", 1).Should().Be("happy");           // return "happy"
            _ = timeMap.Get("alice", 2).Should().Be("happy");           // return "happy", there is no value stored for timestamp 2, thus we return the value at timestamp 1.
            timeMap.Set("alice", "sad", 3);    // store the key "alice" and value "sad" along with timestamp = 3.
            _ = timeMap.Get("alice", 3).Should().Be("sad");
        }

        [TestMethod()]
        public void TimeMapTest2()
        {
            TimeMap timeMap = new();
            timeMap.Set("alice", "happy", 1);  // store the key "alice" and value "happy" along with timestamp = 1.
            _ = timeMap.Get("alice", 1).Should().Be("happy");           // return "happy"
            _ = timeMap.Get("alice", 2).Should().Be("happy");           // return "happy", there is no value stored for timestamp 2, thus we return the value at timestamp 1.
            timeMap.Set("alice", "sad", 3);    // store the key "alice" and value "sad" along with timestamp = 3.
            _ = timeMap.Get("alice", 3).Should().Be("sad");
        }
    }
}