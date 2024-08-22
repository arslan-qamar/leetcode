namespace LeetCodeSolutions.NeetCode.Stacks.Largest_Rectangle_Histogram
{
    public class LargestRectangleHistogramFinder
    {
        public static int LargestRectangleArea(int[] heights)
        {
            int maxArea = 0;

            if (heights == null || heights.Length < 1)
            {
                return maxArea;
            }

            LinkedList<(int Index, int Height)> heightBlocks = new LinkedList<(int, int)>();

            int extendBack = 0;
            for (int i = 0; i < heights.Length; i++)
            {
                extendBack = i;
                while (heightBlocks.Count > 0 && heightBlocks.Last.Value.Height > heights[i])
                {
                    maxArea = Math.Max(maxArea, heightBlocks.Last.Value.Height * (i - heightBlocks.Last.Value.Index));

                    extendBack = heightBlocks.Last.Value.Index;

                    heightBlocks.RemoveLast();
                }

                heightBlocks.AddLast(new LinkedListNode<(int Index, int Height)>((extendBack, heights[i])));
            }

            foreach ((int Index, int Height) item in heightBlocks)
            {
                maxArea = Math.Max(maxArea, item.Height * (heights.Length - item.Index));
            }

            return maxArea;
        }

    }
}
