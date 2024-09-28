
namespace LeetCodeSolutions.NeetCode.Graphs.Pacific_Atlantic_Water_Flow
{
    public class PacificAtlanticWaterFlow
    {
        public List<List<int>> PacificAtlantic(int[][] heights)
        {

            HashSet<(int Row, int Col)> canReachPacific = new HashSet<(int Row, int Col)>();
            HashSet<(int Row, int Col)> canReachAtlantic = new HashSet<(int Row, int Col)>();

            for (int c = 0; c < heights[0].Length; c++)
            {
                Dfs(0, c, canReachPacific, heights[0][c]);
                Dfs(heights.Length - 1, c, canReachAtlantic, heights[heights.Length-1][c]);
            }

            for (int r = 0; r < heights.Length; r++)
            {
                Dfs(r, 0, canReachPacific, heights[r][0]);
                Dfs(r, heights[0].Length - 1, canReachAtlantic, heights[r][heights[0].Length - 1]);
            }

            void Dfs(int row, int col, HashSet<(int Row, int Col)> canReach, int origin)
            {
                if (row < 0 || row >= heights.Length || col < 0 || col >= heights[0].Length || canReach.Contains((row, col)) || heights[row][col] < origin)
                {
                    return;
                }

                canReach.Add((row, col));

                Dfs(row + 1, col, canReach, heights[row][col]);
                Dfs(row - 1, col, canReach, heights[row][col]);
                Dfs(row, col + 1, canReach, heights[row][col]);
                Dfs(row, col - 1, canReach, heights[row][col]);
            }

            return canReachAtlantic.Intersect(canReachPacific).Select(x => new List<int>() { x.Row, x.Col }).ToList();
        }



        public List<List<int>> PacificAtlanticBfs(int[][] heights)
        {
            List<List<int>> result = new List<List<int>>();
            Queue<(int Row, int Col)> bfsQueue = new Queue<(int Row, int Col)>();

            HashSet<(int Row, int Col)> canReachPacific = new HashSet<(int Row, int Col)>();
            //Popluated for Pacific
            populateBorder(0, 0, canReachPacific);
            processQueue(bfsQueue, canReachPacific);

            HashSet<(int Row, int Col)> canReachAtlantic = new HashSet<(int Row, int Col)>();
            //Popluated for Atlantic
            populateBorder(heights.Length - 1, heights[0].Length - 1, canReachAtlantic);
            processQueue(bfsQueue, canReachAtlantic);
            
            void processQueue(Queue<(int Row, int Col)> bfsQueue, HashSet<(int Row, int Col)> canReach)
            {
                while (bfsQueue.Count > 0)
                {
                    int queueLength = bfsQueue.Count;
                    for (int i = 0; i < queueLength; i++)
                    {
                        var entry = bfsQueue.Dequeue();

                        AddNeighbourSpots(entry.Row + 1, entry.Col, heights[entry.Row][entry.Col], canReach);
                        AddNeighbourSpots(entry.Row - 1, entry.Col, heights[entry.Row][entry.Col], canReach);
                        AddNeighbourSpots(entry.Row, entry.Col + 1, heights[entry.Row][entry.Col], canReach);
                        AddNeighbourSpots(entry.Row, entry.Col - 1, heights[entry.Row][entry.Col], canReach);
                    }
                }
            }

            void populateBorder(int row, int col, HashSet<(int Row, int Col)> canReach)
            {
                for (int c = 0; c < heights[0].Length; c++)
                {
                    canReach.Add((row, c));
                    bfsQueue.Enqueue((row, c));
                }

                for (int r = 0; r < heights.Length; r++)
                {
                    canReach.Add((r, col));
                    bfsQueue.Enqueue((r, col));
                }
            }

            void AddNeighbourSpots(int row, int col, int originHeight, HashSet<(int Row, int Col)> canReach)
            {
                if (row < 0 || row >= heights.Length || col < 0 || col >= heights[0].Length || heights[row][col] < originHeight || canReach.Contains((row, col)))
                {
                    return;
                }

                if (heights[row][col] >= originHeight)
                {
                    canReach.Add((row, col));
                    bfsQueue.Enqueue((row, col));
                }

            }

            result = canReachPacific.Intersect(canReachAtlantic).Select(x => new List<int> { x.Row, x.Col }).ToList();
            return result;

           
        }

    }
}
