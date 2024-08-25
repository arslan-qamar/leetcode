namespace Binary_Search.Find_Target_In_Rotated_Sorted_Array
{
    public class FindTargetSortedRotatedArray
    {
        public static int Search(int[] nums, int target)
        {
            if (nums == null || nums.Length < 1)
            {
                return 0;
            }

            int index = -1;

            int l = 0;
            int r = nums.Length - 1;

            while (l <= r)
            {
                int m = (l + r) / 2;

                if (nums[l] == target)
                {
                    index = l;
                    break;
                }

                if (nums[m] == target)
                {
                    index = m;
                    break;
                }


                if (target < nums[m] && (nums[l] < target || nums[l] > nums[m]))
                {
                    r = m - 1;
                }
                else
                {
                    l = m + 1;
                }

            }

            return index;
        }
    }
}
