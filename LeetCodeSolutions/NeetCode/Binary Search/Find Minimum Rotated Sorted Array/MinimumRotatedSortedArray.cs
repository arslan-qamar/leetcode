namespace Binary_Search.Find_Minimum_Rotated_Sorted_Array
{
    public class MinimumRotatedSortedArray
    {
        public static int FindMin(int[] nums)
        {

            if (nums == null || nums.Length < 1)
            {
                return 0;
            }

            if (nums.Length == 1)
            {
                return nums[0];
            }

            int result = int.MaxValue;

            int l = 0;
            int r = nums.Length - 1;

            while (l <= r)
            {
                if (nums[l] < nums[r])
                {
                    result = Math.Min(result, nums[l]);
                    break;
                }

                int m = (l + r) / 2;

                result = Math.Min(result, nums[m]);

                if (nums[m] >= nums[l])
                {
                    l = m + 1;
                }
                else
                {
                    r = m - 1;
                }

            }


            return result;
        }


    }
}
