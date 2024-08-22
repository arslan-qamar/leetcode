namespace Palindrome
{
    public class Palindrome
    {
        public static bool IsPalindrome(string s)
        {
            if (s == null)
            {
                return false;
            }

            int right = s.Length - 1;

            for (int left = 0; left < right; left++, right--)
            {

                while (!IsValid(s[left]) && left < right)
                {
                    left++;
                }

                while (!IsValid(s[right]) && right > left)
                {
                    right--;
                }

                if (s[left].ToString().ToLower() != s[right].ToString().ToLower())
                {
                    return false;
                }
            }
            return true;
        }

        public static bool IsValid(char c)
        {
            return (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || (c >= '0' && c <= '9');

        }
    }
}
