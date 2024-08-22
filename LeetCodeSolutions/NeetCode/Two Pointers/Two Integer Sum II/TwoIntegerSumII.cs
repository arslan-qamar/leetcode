namespace Two_Integer_Sum_II
{
    public class TwoIntegerSumII
    {
        public static int[] TwoSum(int[] numbers, int target)
        {
            int[] result = new int[2];

            int sum;

            for (int l = 0, r = numbers.Length - 1; l < numbers.Length && l < r;)
            {

                sum = numbers[l] + numbers[r];

                if (sum == target)
                {
                    return new int[] { l + 1, r + 1 };
                }

                if (sum < target)
                {
                    l++;
                    continue;
                }

                if (sum > target)
                {
                    r--;
                    continue;
                }
            }

            return result;
        }
    }
}
