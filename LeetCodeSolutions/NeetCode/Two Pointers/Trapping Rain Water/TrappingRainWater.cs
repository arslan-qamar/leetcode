namespace Trapping_Rain_Water
{
    public class TrappingRainWater
    {
        public static int Trap(int[] height)
        {
            int result = 0;
            if (height == null || height.Length < 1)
                return result;

            int l = 0;
            int r = height.Length - 1;

            int lMax = height[l];
            int rMax = height[r];

            while (l < r)
            {

                if (lMax < rMax)
                {
                    l++;
                    lMax = Math.Max(lMax, height[l]);
                    result += lMax - height[l];
                }

                else
                {
                    r--;
                    rMax = Math.Max(rMax, height[r]);
                    result += rMax - height[r];
                }
            }

            return result;
        }
    }
}
