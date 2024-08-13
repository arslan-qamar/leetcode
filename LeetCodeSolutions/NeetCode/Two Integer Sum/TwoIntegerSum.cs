namespace LeetCodeSolutions.NeetCode.Two_Integer_Sum
{
    public class TwoIntegerSum
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            int[] result = new int[] { 0, 0 };
            if (nums == null || nums.Length == 0)
            {
                return result;
            }

            Dictionary<int, int> expected_j = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int number = nums[i];

                int expectedNumber = target - number;

                if (expected_j.Keys.Contains(expectedNumber))
                {
                    return new int[] { expected_j[expectedNumber], i };
                }

                expected_j.Add(number, i);
            }

            return result;
        }
    }
}
