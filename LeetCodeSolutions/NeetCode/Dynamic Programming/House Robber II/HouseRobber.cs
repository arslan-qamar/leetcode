namespace LeetCodeSolutions.NeetCode.Dynamic_Programming.House_Robber_II
{
    public class HouseRobber
    {
        public int Rob(int[] nums)
        {
            if (nums.Length == 1)
            {
                return nums[0];
            }

            int maxRob = 0;

            int rob1 = 0;
            int rob2 = 0;

            for (int i = 0; i < nums.Length-1; i++)
            {
                int temp = Math.Max(rob1 + nums[i], rob2);
                rob1 = rob2;
                rob2 = temp;
            }

            maxRob = Math.Max(maxRob, rob2);
            rob1 = 0;
            rob2 = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                int temp = Math.Max(rob1 + nums[i], rob2);
                rob1 = rob2;
                rob2 = temp;
            }
            maxRob = Math.Max(maxRob, rob2);

            return maxRob;
        }
    }
}
