using FluentAssertions;
using LeetCodeSolutions.NeetCode.BackTracking.Palindrome_Partitioning;

namespace Palindrome_Partitioning
{
    [TestClass()]
    public class PalindromePartitionTests
    {
        [TestMethod()]
        public void PartitionTest()
        {
           var result = PalindromePartition.Partition("aab").Should().BeEquivalentTo(
               
               new List<List<string>>()
               {
                   new List<string>(){ "a", "a", "b" },
                   new List<string>(){ "aa", "b" }
               }
               
               );

        }
    }
}