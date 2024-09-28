namespace LeetCodeSolutions.NeetCode.Graphs.NumIslands
{
    public class NumberOfIslands
    {
        public static int NumIslands(char[][] grid)
        {

            int islands = 0;

            int rows = grid.Length;
            int cols = grid[0].Length;

            HashSet<(int row, int col)> visted = new HashSet<(int row, int col)>();


            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    if (grid[r][c] == '1' && !visted.Contains((r, c)))
                    {
                        dfs(r, c);
                        islands++;
                    }
                }
            }

            void dfs(int row, int col)
            {
                if (
                    row < 0 || row >= rows ||
                    col < 0 || col >= cols ||
                    grid[row][col] == '0' || visted.Contains((row, col))
                   )
                {
                    return;
                }

                visted.Add((row, col));

                dfs(row + 1, col);
                dfs(row - 1, col);

                dfs(row, col + 1);
                dfs(row, col - 1);
            }

            return islands;
        }
    }
}
