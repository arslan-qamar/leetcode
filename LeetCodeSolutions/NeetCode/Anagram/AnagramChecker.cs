namespace LeetCodeSolutions.NeetCode.IsAnagram
{
    public class AnagramChecker
    {
        public static bool IsAnagram(string s, string t)
        {
            if (s == null || t == null || (s.Length != t.Length))
            {
                return false;
            }

            int[] finalCharCount = new int[26];

            for (int i = 0; i < s.Length; i++)
            {
                finalCharCount[getCharIndex(s[i])] = ++finalCharCount[getCharIndex(s[i])];
                finalCharCount[getCharIndex(t[i])] = --finalCharCount[getCharIndex(t[i])];
            }

            foreach (int count in finalCharCount)
            {
                if (count != 0)
                {
                    return false;
                }
            }

            return true;
        }

        private static int getCharIndex(char v)
        {
            return v - 'a';
        }
    }
}
