namespace LeetCodeSolutions.NeetCode.BuySellCrypto
{
    public class BuySellPrice
    {
        public static int MaxProfit(int[] prices)
        {
            int maxProfit = 0;

            if (prices == null || prices.Length < 1)
            {
                return maxProfit;
            }

            int minimumPriceSeen = prices[0];

            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] - minimumPriceSeen > maxProfit)
                {
                    maxProfit = prices[i] - minimumPriceSeen;
                }

                if (prices[i] < minimumPriceSeen)
                {
                    minimumPriceSeen = prices[i];
                }

            }

            return maxProfit;
        }
    }
}
