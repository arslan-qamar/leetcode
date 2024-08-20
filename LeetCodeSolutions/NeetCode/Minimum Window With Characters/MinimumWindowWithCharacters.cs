namespace LeetCodeSolutions.NeetCode.Minimum_Window_With_Characters
{
    public class MinimumWindowWithCharacters
    {
        public static string MinWindow(string s, string t)
        {
            string result = string.Empty;

            if (s == null || s.Length == 0 || t == null || t.Length == 0 || s.Length < t.Length)
            {
                return result;
            }

            Dictionary<char, int> targetCharCounts = new Dictionary<char, int>();

            foreach (char c in t)
            {
                targetCharCounts[c] = targetCharCounts.TryGetValue(c, out int value) ? value + 1 : 1;
            }

            Dictionary<char, int> sourceCharCount = new Dictionary<char, int>();

            int l = 0;
            int r = 0;

            int[] res = new int[] { -1, -1 };
            int minimumWindowSize = int.MaxValue;
            int matched = 0;
            int targetmatches = targetCharCounts.Count;


            while (l <= r && r < s.Length)
            {
                if (targetCharCounts.ContainsKey(s[r]))
                {
                    sourceCharCount[s[r]] = sourceCharCount.TryGetValue(s[r], out int value) ? value + 1 : 1;

                    if (targetCharCounts[s[r]] == sourceCharCount[s[r]])
                    {
                        matched++;
                    }
                }

                while (matched == targetmatches)
                {
                    int windowSize = r - l + 1;
                    if (windowSize < minimumWindowSize)
                    {
                        res = new int[] { l, r };
                        minimumWindowSize = r - l + 1;
                    }

                    if (targetCharCounts.ContainsKey(s[l]))
                    {
                        sourceCharCount[s[l]]--;
                    }

                    if (targetCharCounts.ContainsKey(s[l]) && sourceCharCount[s[l]] < targetCharCounts[s[l]])
                    {
                        matched--;
                    }
                    l++;
                }

                r++;
            }

            if (res[0] != -1 && res[1] != -1)
            {
                return s.Substring(res[0], res[1] - res[0] + 1);
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
