namespace LeetCodeSolutions.NeetCode.Dynamic_Programming.House_Robber
{
    public class HouseRobberAdjacent
    {
        public int Rob(int[] nums)
        {
            int rob1 = 0, rob2 = 0;

            foreach (var n in nums)
            {
                int temp = Math.Max(rob1 + n, rob2);
                rob1 = rob2;
                rob2 = temp;
            }

            return rob2;
        }
    }
}
