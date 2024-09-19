using FluentAssertions;

namespace BuySellCrypto
{
    [TestClass()]
    public class BuySellPriceTests
    {
        [TestMethod()]
        public void MaxProfitTest()
        {
            _ = BuySellPrice.MaxProfit(new int[] { 10, 1, 5, 6, 7, 1 }).Should().Be(6);
            _ = BuySellPrice.MaxProfit(new int[] { 10, 8, 7, 5, 2 }).Should().Be(0);
            _ = BuySellPrice.MaxProfit(new int[] { 10, 8, 7, 5, 2, 102 }).Should().Be(100);
            _ = BuySellPrice.MaxProfit(new int[] { }).Should().Be(0);
            _ = BuySellPrice.MaxProfit(new int[] { 0, 8, 7, 5, 2, 102 }).Should().Be(102);
        }
    }
}