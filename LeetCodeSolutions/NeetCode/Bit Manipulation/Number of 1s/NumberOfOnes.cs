namespace LeetCodeSolutions.NeetCode.Bit_Manipulation.Number_of_1s
{
    public class NumberOfOnes
    {
        public int HammingWeight(int n)
        {
            int count = 0;
            while (n != 0)
            {
                n = n & (n - 1);
                count++;
            }
            return count;

        }
    }
}
