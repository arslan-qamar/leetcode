using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Car_Fleet
{
    [TestClass()]
    public class CarFleetFinderTests
    {
        [TestMethod()]
        public void CarFleetTest()
        {
            CarFleetFinder.CarFleet(10, new int[] { 1, 4 }, new int[] { 3, 2 }).Should().Be(1);
        }

        [TestMethod()]
        public void CarFleetTest2()
        {
            CarFleetFinder.CarFleet(10, new int[] { 4, 1, 0, 7 }, new int[] { 2, 2, 1, 1 }).Should().Be(3);
        }

        [TestMethod()]
        public void CarFleetTest3()
        {
            CarFleetFinder.CarFleet(12, new int[] { 10, 8, 0, 5, 3 }, new int[] { 2, 4, 1, 1, 3 }).Should().Be(3);
        }

        [TestMethod()]
        public void CarFleetTest4()
        {
            CarFleetFinder.CarFleet(10, new int[] { 6, 8 }, new int[] { 3, 2 }).Should().Be(2);
        }


    }
}