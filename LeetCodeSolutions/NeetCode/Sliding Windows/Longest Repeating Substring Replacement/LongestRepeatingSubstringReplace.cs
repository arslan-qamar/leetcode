namespace Longest_Repeating_Substring_Replacement
{
    public class LongestRepeatingSubstringReplace
    {

        public static int CharacterReplacement(string s, int k)
        {
            if (s == null || s.Length == 0)
            {
                return 0;
            }

            int longestSubString = 0;

            int l = 0;

            Dictionary<char, int> countMap = new Dictionary<char, int>();

            for (int r = 0; r < s.Length; r++)
            {
                countMap[s[r]] = countMap.TryGetValue(s[r], out int curr) ? curr + 1 : 1;

                int maxCount = FindMaxCount(countMap);

                int windowSize = r - l + 1;

                if (windowSize - maxCount <= k)
                {

                    longestSubString = Math.Max(longestSubString, windowSize);
                }

                while (windowSize - maxCount > k)
                {
                    countMap[s[l]] -= 1;
                    l++;
                    windowSize = r - l + 1;
                    maxCount = FindMaxCount(countMap);
                }
            }

            return longestSubString;
        }

        private static int FindMaxCount(Dictionary<char, int> countMap)
        {
            int maxCount = 0;
            foreach (KeyValuePair<char, int> item in countMap)
            {
                if (item.Value > maxCount)
                {
                    maxCount = item.Value;
                }
            }

            return maxCount;
        }
    }
}
