namespace Max_Water_Container
{
    public class MaxWaterContainerCalculator
    {

        public static int MaxArea(int[] heights)
        {
            if (heights == null || heights.Length < 1)
            {
                return 0;
            }

            int maxArea = 0;

            int l = 0;
            int r = heights.Length - 1;

            while (l < r && l < heights.Length - 1 && r >= 0)
            {
                int minHeight = Math.Min(heights[l], heights[r]);

                int area = minHeight * (r - l);

                if (area > maxArea)
                {
                    maxArea = area;
                }

                if (heights[l] > heights[r])
                {
                    r--;
                    continue;
                }

                if (heights[r] > heights[l])
                {
                    l++;
                    continue;
                }

                if (heights[l] == heights[r])
                {
                    l++;
                    continue;
                }
            }

            return maxArea;
        }
    }
}
