using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeSolutions.NeetCode.Linked_List.Add_Two_Numbers.Tests
{
    [TestClass()]
    public class LinkedListAddTwoNumbersTests
    {
        [TestMethod()]
        public void AddTwoNumbersTest()
        {

            ListNode l1 = new ListNode(1, new ListNode(2, new ListNode(3, null)));
            ListNode l2 = new ListNode(4, new ListNode(5, new ListNode(6, null)));

            LinkedListAddTwoNumbers.AddTwoNumbers(l1, l2).Should().BeEquivalentTo(
                new ListNode(5, new ListNode(7, new ListNode(9, null)))
                );
        }

        [TestMethod()]
        public void AddTwoNumbersTest2()
        {

            ListNode l1 = new ListNode(9, null);
            ListNode l2 = new ListNode(9, null);

            LinkedListAddTwoNumbers.AddTwoNumbers(l1, l2).Should().BeEquivalentTo(
                new ListNode(8, new ListNode(1, null))
                );
        }
    }
}
