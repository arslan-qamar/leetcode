namespace Longest_Substring_Without_Duplicates
{
    public class LongestSubstring
    {

        public static int LengthOfLongestSubstring(string s)
        {
            if (s.Length < 1)
            {
                return 0;
            }

            int longestSubString = 0;

            int l = 0;

            HashSet<int> duplicateSet = new HashSet<int>();

            for (int r = 0; r < s.Length; r++)
            {
                while (duplicateSet.Contains(s[r]))
                {
                    duplicateSet.Remove(s[l]);
                    l++;
                }

                duplicateSet.Add(s[r]);

                longestSubString = Math.Max(longestSubString, r - l + 1);
            }

            return longestSubString;
        }

    }
}
