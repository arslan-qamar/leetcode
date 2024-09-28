namespace LeetCodeSolutions.NeetCode.Graphs.Islands_and_Treasure
{
    public class IslandTreasure
    {

        public static void islandsAndTreasure(int[][] grid)
        {
            HashSet<(int Row, int Col)> visited = new HashSet<(int Row, int Col)>();
            Queue<(int Row, int Col)> queue = new Queue<(int, int)>();

            // Add the Gates to Queue first 
            for (int r = 0; r < grid.Length; r++)
            {
                for (int c = 0; c < grid[0].Length; c++)
                {
                    if (grid[r][c] == 0)
                    {
                        visited.Add((r, c));
                        queue.Enqueue((r, c));
                    }
                }
            }
            
            int distance = 0;

            // Now we do BFS for each layer (using the current lenght of Queue pop and process while adding new items)
            while(queue.Count > 0)
            {

                int count = queue.Count;
                for (int i = 0; i < count; i++)
                {

                    var item = queue.Dequeue();

                    grid[item.Row][item.Col] = distance;

                    AddPosition(item.Row + 1, item.Col);
                    AddPosition(item.Row - 1, item.Col);
                    AddPosition(item.Row, item.Col + 1);
                    AddPosition(item.Row, item.Col - 1);

                }
                distance += 1;
            }

            void AddPosition(int row, int col)
            {
                if(row < 0 || row >= grid.Length || col < 0 || col >= grid[0].Length || grid[row][col] == -1 || visited.Contains((row,col)))
                {
                    return;
                }

                queue.Enqueue((row, col));
                visited.Add((row, col));
            }

        }


        public static void islandsAndTreasureDfs(int[][] grid)
        {

            HashSet<(int Row, int Col)> visited = new HashSet<(int Row, int Col)>();
            int minDis = int.MaxValue;


            for (int r = 0; r < grid.Length; r++)
            {
                for (int c = 0; c < grid[0].Length; c++)
                {
                    if (grid[r][c] == int.MaxValue)
                    {
                        visited.Clear();
                        minDis = int.MaxValue;
                        Dfs(r, c);
                        grid[r][c] = minDis;                        
                    }
                }
            }

            void Dfs(int r, int c, int steps=0)
            {
                if(r < 0 || r >= grid.Length || c < 0 || c >= grid[0].Length || grid[r][c] == -1 || visited.Contains((r,c)))
                {
                    return;
                }

                if (grid[r][c] == 0)
                {
                    minDis = Math.Min(minDis, steps);
                    return;
                }

                visited.Add((r, c));

                Dfs(r + 1, c, steps + 1);
                Dfs(r - 1, c, steps + 1);
                Dfs(r, c + 1, steps + 1); 
                Dfs(r, c - 1, steps + 1);

                visited.Remove((r, c));
            }
        }

    }
}
