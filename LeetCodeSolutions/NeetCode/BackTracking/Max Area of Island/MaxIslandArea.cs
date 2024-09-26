
namespace LeetCodeSolutions.NeetCode.Graphs.Max_Area_of_Island
{
    public class MaxIslandArea
    {

        public int MaxAreaOfIsland(int[][] grid)
        {
            int maxArea = 0;

            HashSet<(int Row, int Col)> visited = new HashSet<(int,int)>();

            for (int r = 0; r < grid.Length; r++)
            {
                for (int c = 0; c < grid[0].Length; c++)
                {
                    if (grid[r][c] == 1 && !visited.Contains((r, c)))
                    {
                        maxArea = Math.Max(maxArea, Dfs(r, c));
                    }
                }
            }

            int Dfs(int r, int c)
            {
                if (r < 0 || r == grid.Length || c < 0 || c == grid[0].Length || grid[r][c] == 0 || visited.Contains((r, c)))
                {
                    return 0;
                }

                visited.Add((r, c));

                return 1 + Dfs(r + 1, c) + Dfs(r - 1, c) +  Dfs(r, c + 1)  +  Dfs(r, c - 1);
            }

            return maxArea;
        }

    }
}
