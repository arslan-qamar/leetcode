using FluentAssertions;

namespace LeetCodeSolutions.NeetCode.Heaps_And_Priority_Queue.Twitter.Tests
{
    [TestClass()]
    public class TwitterTests
    {
        [TestMethod()]
        public void GetNewsFeedTest()
        {
            Twitter twitter = new Twitter();
            twitter.PostTweet(1, 10); // User 1 posts a new tweet with id = 10.
            twitter.PostTweet(2, 20); // User 2 posts a new tweet with id = 20.
            twitter.GetNewsFeed(1).Should().BeEquivalentTo(

                new List<int>() { 10 }

                );   // User 1's news feed should only contain their own tweets -> [10].


            twitter.GetNewsFeed(2).Should().BeEquivalentTo(

                new List<int>() { 20 }

                );   // User 2's news feed should only contain their own tweets -> [20].



            twitter.Follow(1, 2);     // User 1 follows user 2.


            twitter.GetNewsFeed(1).Should().ContainInOrder(

                new List<int>() { 20, 10 }

                );   // User 1's news feed should contain both tweets from user 1 and user 2 -> [20, 10].



            twitter.GetNewsFeed(2).Should().BeEquivalentTo(

                new List<int>() { 20 }

                );   // User 2's news feed should still only contain their own tweets -> [20].


            twitter.Unfollow(1, 2);   // User 1 follows user 2.

            twitter.GetNewsFeed(1).Should().BeEquivalentTo(

                new List<int>() { 10 }

                );   // User 1's news feed should only contain their own tweets -> [10].


        }

      
    }
}