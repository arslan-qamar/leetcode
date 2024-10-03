namespace LeetCodeSolutions.NeetCode.Bit_Manipulation.ReverseBits
{
    public class ReverserBits
    {
        public uint ReverseBits(uint n)
        {
            uint result = 0;

            for (int i = 0; i < 31; i++)
            {

                uint bit = (n >> i) & 1;

                result += (bit << (31 - i));
            }

            return result;
        }

    }
}
