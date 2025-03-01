﻿using FluentAssertions;

namespace Max_Water_Container
{
    [TestClass()]
    public class MaxWaterContainerCalculatorTests
    {
        [TestMethod()]
        public void MaxAreaTest()
        {
            _ = MaxWaterContainerCalculator.MaxArea(new int[] { 1, 7, 2, 5, 4, 7, 3, 6 }).Should().Be(36);
            _ = MaxWaterContainerCalculator.MaxArea(new int[] { 2, 2, 2 }).Should().Be(4);
            _ = MaxWaterContainerCalculator.MaxArea(new int[] { }).Should().Be(0);

        }

        [TestMethod()]
        public void SpecialCase()
        {
            _ = MaxWaterContainerCalculator.MaxArea(new int[] { 1, 7, 2, 5, 12, 3, 500, 500, 7, 8, 4, 7, 3, 6 }).Should().Be(500);
        }

    }
}