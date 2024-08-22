namespace Permutation_In_String
{
    public class PermutationString
    {
        public static bool CheckInclusion(string s1, string s2)
        {

            if (s1 == null || s2 == null || s1.Length < 1 || s2.Length < 1 || s1.Length > s2.Length)
            {
                return false;
            }

            int[] s1CharCount = new int[26];

            foreach (char c in s1)
            {
                s1CharCount[c - 'a'] += 1;
            }

            int windowSize = s1.Length;

            int[] s2CharCount = new int[26];

            for (int i = 0; i < windowSize; i++)
            {
                s2CharCount[s2[i] - 'a'] += 1;
            }


            int matches = 0;

            for (int i = 0; i < 26; i++)
            {
                if (s1CharCount[i] == s2CharCount[i])
                {
                    matches++;
                }
            }


            for (int r = windowSize; r < s2.Length && matches != 26; r++)
            {
                char newRightChar = s2[r];
                s2CharCount[newRightChar - 'a'] += 1;

                if (s2CharCount[newRightChar - 'a'] == s1CharCount[newRightChar - 'a'])
                {
                    matches++;
                }
                else if (s2CharCount[newRightChar - 'a'] - 1 == s1CharCount[newRightChar - 'a'])
                {
                    matches--;
                }

                char leftChar = s2[r - windowSize];
                s2CharCount[leftChar - 'a'] -= 1;

                if (s2CharCount[leftChar - 'a'] == s1CharCount[leftChar - 'a'])
                {
                    matches++;
                }
                else if (s2CharCount[leftChar - 'a'] + 1 == s1CharCount[leftChar - 'a'])
                {
                    matches--;
                }
            }

            return matches == 26;
        }

    }
}
