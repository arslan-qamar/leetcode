namespace Reverse_Integer
{
    public class ReverseInteger
    {
        public int Reverse(int x)
        {
            int result = 0;
            int num = x;

            while (num != 0)
            {
                int digit = num % 10;
                num = num / 10;

                if (
                    (result > int.MaxValue / 10 || (result == int.MaxValue / 10 && digit > int.MaxValue % 10)) ||
                    (result < int.MinValue / 10 || (result == int.MinValue / 10 && digit > int.MinValue % 10))
                   )
                {
                    return 0;
                }

                result = result * 10 + digit;
            }

            return result;
        }
    }
}
