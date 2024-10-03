namespace LeetCodeSolutions.NeetCode.Bit_Manipulation
{
    public class SingleDigitFinder
    {
        public int SingleNumber(int[] nums)
        {
            int result = 0;

            foreach (var n in nums)
            {
                result ^= n;
            }

            return result;
        }
    }
}
