using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Task_Scheduler.Tests
{
    [TestClass()]
    public class TaskSchedulerTests
    {
        [TestMethod()]
        public void LeastIntervalTest()
        {
            TaskScheduler.LeastInterval(new char[] { 'X', 'X', 'Y', 'Y' }, 2).Should().Be(5);
        }

        [TestMethod()]
        public void LeastIntervalTest2()
        {
            TaskScheduler.LeastInterval(new char[] { 'A', 'A', 'A', 'B', 'C' }, 3).Should().Be(9);
        }


        [TestMethod()]
        public void LeastIntervalTest3()
        {
            TaskScheduler.LeastInterval(new char[] { 'A', 'A', 'A', 'B', 'B', 'B', 'C', 'C', 'C', 'D', 'D', 'E' }, 2).Should().Be(12);
        }

    }
}