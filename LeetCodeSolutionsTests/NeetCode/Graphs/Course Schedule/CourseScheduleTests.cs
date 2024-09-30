using FluentAssertions;
using LeetCodeSolutions.NeetCode.Graphs.Course_Schedule;

namespace Course_Schedule.Tests
{
    [TestClass()]
    public class CourseScheduleTests
    {
        [TestMethod()]
        public void CanFinishTest()
        {
            CourseSchedule c = new CourseSchedule();

            c.CanFinish(2,[[0, 1]]).Should().BeTrue();

        }

        [TestMethod()]
        public void CantFinishTest()
        {
            CourseSchedule c = new CourseSchedule();

            c.CanFinish(2, [[0, 1], [1, 0]]).Should().BeFalse();

        }
    }
}