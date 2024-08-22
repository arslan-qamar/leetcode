namespace LeetCodeSolutions.NeetCode.Binary_Search
{
    public class BinarySearch
    {
        public static int Search(int[] nums, int target)
        {
            int result = -1;

            int l = 0;
            int r = nums.Length - 1;

            while (l <= r)
            {
                int m = l + ((r - l) / 2);

                if (nums[m] > target)
                {
                    r = m - 1;
                }
                else if (nums[m] < target)
                {
                    l = m + 1;
                }
                else
                {
                    return m;
                }
            }

            return result;
        }
    }
}
