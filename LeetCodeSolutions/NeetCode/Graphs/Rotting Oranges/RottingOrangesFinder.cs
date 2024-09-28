namespace LeetCodeSolutions.NeetCode.Graphs.Rotting_Oranges
{
    public class RottingOrangesFinder
    {
        public int OrangesRotting(int[][] grid)
        {
            int result = 0;

            HashSet<(int Row, int Col)> visited = new HashSet<(int Row, int Col)>();

            Queue<(int Row, int Col)> bfsQueue = new Queue<(int Row, int Col)>();

            int freshFruit = 0;
            for (int r = 0; r < grid.Length; r++)
            {
                for (int c = 0; c < grid[0].Length; c++)
                {
                    if (grid[r][c] == 1)
                    {
                        freshFruit++;
                    }

                    if (grid[r][c]== 2)
                    {
                        bfsQueue.Enqueue((r, c));
                        visited.Add((r, c));
                    }
                }
            }

            
            while(bfsQueue.Count > 0)
            {
                int itemsInQueue = bfsQueue.Count;
                for (int i = 0; i < itemsInQueue; i++)
                {
                    var entry = bfsQueue.Dequeue();

                    UpdateNeighbourFruits(entry.Row, entry.Col + 1);
                    UpdateNeighbourFruits(entry.Row, entry.Col - 1);
                    UpdateNeighbourFruits(entry.Row + 1, entry.Col);
                    UpdateNeighbourFruits(entry.Row - 1, entry.Col);

                }

                if(bfsQueue.Count > 0)
                {
                    if (result == -1)
                    {
                        result = 1;                     
                    }
                    else
                    {
                        result++;
                    }
                }
            }

            void UpdateNeighbourFruits(int r, int c)
            {
                if (r < 0 || r >= grid.Length || c < 0 || c >= grid[0].Length || grid[r][c] == 0 || visited.Contains((r, c)))
                {
                    return;
                }

                if (grid[r][c] == 1)
                {
                    freshFruit--;
                    grid[r][c] = grid[r][c] + 1;                
                    bfsQueue.Enqueue((r, c));
                    visited.Add((r, c));
                }
            }

            return freshFruit == 0 ? result : -1;
        }

    }
}
