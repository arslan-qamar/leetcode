namespace LeetCodeSolutions.NeetCode.Bit_Manipulation.Missing_Number
{
    public class MissingNumberFinder
    {
        public int MissingNumber(int[] nums)
        {
            int xor1 = 0, xor2 = 0;

            // XOR all array elements
            for (int i = 0; i < nums.Length; i++)
            {
                xor2 ^= nums[i];
            }

            // XOR all numbers from 1 to n
            for (int i = 1; i <= nums.Length; i++)
            {
                xor1 ^= i;
            }

            // Missing number is the XOR of xor1 and xor2
            return xor1 ^ xor2;
        }

        public int MissingNumberGuass(int[] nums)
        {
            int result = (nums.Length * (nums.Length + 1)) / 2;

            for (int i = 0; i < nums.Length; i++)
            {
                result = result - nums[i];
            }

            return result;

        }
    }
}
