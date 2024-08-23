namespace LeetCodeSolutions.NeetCode.Binary_Search.Eating_Bananas
{
    public class EatingBananas
    {

        public static int MinEatingSpeed(int[] piles, int h)
        {

            if (piles == null || piles.Length < 1 || h == 0 || piles.Length > h)
            {
                return 0;
            }

            int l = 1;
            int r = piles.Max();

            int minK = int.MaxValue;

            while (l <= r)
            {
                int k = l + ((r - l) / 2);

                int currH = 0;
                for (int i = 0; i < piles.Length; i++)
                {
                    currH = currH + (int)Math.Ceiling((double)piles[i] / k);
                }

                if (currH > h)
                {
                    l = k + 1;
                }
                else if (currH <= h)
                {
                    r = k - 1;
                    minK = Math.Min(minK, k);
                }
            }

            return minK;
        }

    }
}
