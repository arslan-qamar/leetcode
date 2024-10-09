
namespace Advance_Graphs.Swim_In_Rising_Water
{
    public class SwimInRisingWater
    {
        public int SwimInWater(int[][] grid)
        {
            int[][] directions = new int[][] {

            new int[]{1, 0 },
            new int[] {-1, 0 },
            new int[] {0, 1 },
            new int[] {0, -1 }

            };

            SortedSet<(int cost, int r, int c)> minHeap = new SortedSet<(int cost, int r, int c)>();
            minHeap.Add((grid[0][0], 0, 0));

            HashSet<(int r, int c)> visited = new HashSet<(int r, int c)>();

            while(minHeap.Count > 0)
            {
                var curr = minHeap.Min;
                minHeap.Remove(curr);

                if(curr.r == grid.Length-1 && curr.c == grid[0].Length-1)
                {
                    return curr.cost;
                }

                foreach (var direction in directions)
                {                    
                    int r = curr.r + direction[0];
                    int c = curr.c + direction[1];

                    if (r < 0 || r >= grid.Length || c < 0 || c >= grid[0].Length || visited.Contains((r, c)))
                    { continue; }

                    visited.Add((r, c));
                    minHeap.Add((Math.Max(curr.cost, grid[r][c]), r, c));
                }
            }

            return -1;

        }


        
    }
}
