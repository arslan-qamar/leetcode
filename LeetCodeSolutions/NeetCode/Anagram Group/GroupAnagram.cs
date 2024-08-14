namespace LeetCodeSolutions.NeetCode.AnagramGroup
{
    public class GroupAnagram
    {
        public static List<List<string>> GroupAnagrams(string[] strs)
        {
            Dictionary<string, List<string>> result = new Dictionary<string, List<string>>();

            if (strs.Length == 0)
            {
                return result.Values.ToList();
            }

            if (strs.Length == 1)
            {
                return new List<List<string>>() { new List<string>() { strs[0] } };
            }

            for (int i = 0; i < strs.Length; i++)
            {
                string str = strs[i];

                int[] strCharCount = getCharCount(str);

                string anagramKey = string.Join(' ', strCharCount);

                if (result.ContainsKey(anagramKey))
                {
                    result[anagramKey].Add(str);
                }
                else
                {
                    result.Add(anagramKey, new List<string>() { str });
                }
            }

            return result.Values.ToList();
        }

        private static int[] getCharCount(string str)
        {
            int[] charCount = new int[26];
            foreach (char c in str)
            {
                charCount[c - 'a'] = ++charCount[c - 'a'];
            }

            return charCount;
        }
    }
}
