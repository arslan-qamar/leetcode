namespace LeetCodeSolutions.NeetCode.Bit_Manipulation.Number_of_1s_for_Range
{
    public class NumberOfOnesRange
    {

        public int[] CountBits(int n)
        {
            int[] dp = new int[n + 1];

            int offset = 1;

            for (int i = 1; i <= n; i++)
            {
                if (offset * 2 == i)
                {
                    offset = i;
                }

                dp[i] = 1 + dp[i - offset];
            }
            return dp;
        }

        public int[] CountBitsHammingWeight(int n)
        {
            if (n == 0)
            {
                return new int[] { 0 };
            }

            int[] res = new int[n + 1];

            for (int i = 0; i <= n; i++)
            {
                int num = i;
                int count = 0;
                while(num !=0)
                {
                    num = num & (num - 1);
                    count++;
                }

                res[i] = count;
            }

            return res;
        }
    }
}
