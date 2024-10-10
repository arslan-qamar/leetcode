namespace LeetCodeSolutions.NeetCode.Dynamic_Programming
{
    public  class ClimbingStairs
    {

        public int ClimbStairs(int n)
        {
            int one = 1;
            int two = 1;
            
            for (int i = 0; i < n-1; i++)
            {
                int temp = one;
                one = one + two;
                two = temp;
            }

            return one;
        }

            public int ClimbStairsDFS(int n)
        {
            int result = 0;

            int[] steps = new int[] { 1, 2 };

            Dfs();

            void Dfs(int currentSteps = 0)
            {
                if (currentSteps > n)
                {
                    return;
                }

                if (currentSteps == n)
                {
                    result++;
                    return;
                }                

                currentSteps += steps[0];
                Dfs(currentSteps);

                currentSteps -= steps[0];

                currentSteps += steps[1];
                Dfs(currentSteps);
            }

            return result;
        }

    }
}
