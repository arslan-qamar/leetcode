namespace LeetCodeSolutions.NeetCode.Dynamic_Programming.Stairs_Climbing_Cost
{
    public class StairsCost
    {
        public int MinCostClimbingStairs(int[] cost)
        {            
            for (int i = cost.Length-3; i>=0; i--)
            {
                cost[i] += Math.Min(cost[i + 1], cost[i + 2]);
            }

            return Math.Min(cost[0], cost[1]);
        }

        public int MinCostClimbingStairsDFS(int[] cost)
        {
            int totalCost = int.MaxValue;
            int[] steps = new int[] { 1, 2 };

            Dfs();
            Dfs(1);
            void Dfs(int currentSteps = 0, int currentCost = 0)
            {
                if (currentSteps > cost.Length)
                {
                    return;
                }

                if (currentSteps == cost.Length)
                {
                    totalCost = Math.Min(totalCost, currentCost);
                    return;
                }
                                
                currentCost += cost[currentSteps];
                currentSteps += steps[0];
                Dfs(currentSteps, currentCost);

                currentSteps -= steps[0];
                currentCost -= cost[currentSteps];
                
                currentCost += cost[currentSteps];
                currentSteps += steps[1];
                Dfs(currentSteps, currentCost);
            }




            return totalCost;
        }
    }
}
