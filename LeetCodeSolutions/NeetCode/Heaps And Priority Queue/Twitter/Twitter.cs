namespace LeetCodeSolutions.NeetCode.Heaps_And_Priority_Queue.Twitter
{
    public class Twitter
    {
        Dictionary<int, SortedSet<int>> timeline;

        Dictionary<int, HashSet<int>> following;

        public Twitter()
        {
            timeline = new Dictionary<int, SortedSet<int>>();
                
            following = new Dictionary<int, HashSet<int>>();
        }

        public void PostTweet(int userId, int tweetId)
        {
            if(!timeline.ContainsKey(userId))
            {
                timeline[userId] = new SortedSet<int>(Comparer<int>.Create((x, y) => y.CompareTo(x)));
            }

            timeline[userId].Add(tweetId);
        }

        public List<int> GetNewsFeed(int userId)
        {
            List<int> result = new List<int>();

            HashSet<int> tweetFeedUsers = this.following.TryGetValue(userId, out HashSet<int> fl) ? fl : new HashSet<int>();

            tweetFeedUsers.Add(userId);

            SortedSet<int> userTimeline = new SortedSet<int>(Comparer<int>.Create((x, y) => y.CompareTo(x)));

            foreach (var user in tweetFeedUsers)
            {
                if (timeline.ContainsKey(user))
                {
                    foreach (var tweetId in timeline[user])
                    {
                        userTimeline.Add(tweetId);
                    }
                }
            }

            int count = 0;
            foreach (var tweetId in userTimeline)
            {
                result.Add(tweetId);
                count++;

                if(count == 10)
                {
                    break;
                }
            }
            
            return result;
        }

        public void Follow(int followerId, int followeeId)
        {

            if (!this.following.ContainsKey(followerId))
            {
                this.following[followerId] = new HashSet<int>();
            }

            if (!this.following[followerId].Contains(followeeId))
            {
                this.following[followerId].Add(followeeId);
            }

        }

        public void Unfollow(int followerId, int followeeId)
        {
            if (this.following.ContainsKey(followerId))
            {
                this.following[followerId].Remove(followeeId);
            }
        }

    }
}
