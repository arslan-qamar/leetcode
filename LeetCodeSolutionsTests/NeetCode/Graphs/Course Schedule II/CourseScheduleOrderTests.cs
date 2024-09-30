using FluentAssertions;

namespace LeetCodeSolutions.NeetCode.Graphs.Course_Schedule_II.Tests
{
    [TestClass()]
    public class CourseScheduleOrderTests
    {
        [TestMethod()]
        public void FindOrderTest()
        {
            CourseScheduleOrder c = new CourseScheduleOrder();

            c.FindOrder(3, [[1, 0]]).Should().BeEquivalentTo(new int[] {0,1,2});
        }
    }
}