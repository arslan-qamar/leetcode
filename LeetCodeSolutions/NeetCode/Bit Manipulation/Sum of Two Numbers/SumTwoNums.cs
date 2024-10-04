namespace LeetCodeSolutions.NeetCode.Bit_Manipulation.Sum_of_Two_Numbers
{
    public class SumTwoNums
    {
        public int GetSum(int a, int b)
        {
            if(a == 0 || b == 0)
            {
                return a | b;
            }

            return GetSum(a ^ b, (a & b) << 1);
        }

    }
}
