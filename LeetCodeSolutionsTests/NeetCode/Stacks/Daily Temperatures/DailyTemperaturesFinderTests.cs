using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Daily_Temperatures
{
    [TestClass()]
    public class DailyTemperaturesFinderTests
    {
        [TestMethod()]
        public void DailyTemperaturesTest()
        {
            DailyTemperaturesFinder.DailyTemperatures(new int[] { 30, 38, 30, 36, 35, 40, 28 }).Should().BeEquivalentTo(new int[] { 1, 4, 1, 2, 1, 0, 0 });
            DailyTemperaturesFinder.DailyTemperatures(new int[] { 22, 21, 20 }).Should().BeEquivalentTo(new int[] { 0, 0, 0 });
        }
    }
}