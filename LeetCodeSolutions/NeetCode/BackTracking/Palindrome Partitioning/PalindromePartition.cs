namespace LeetCodeSolutions.NeetCode.BackTracking.Palindrome_Partitioning
{
    public class PalindromePartition
    {
        public static List<List<string>> Partition(string s)
        {
            List<List<string>> result = new List<List<string>>();

            List<string> substrings = new List<string>();

            Dfs(0);

            return result;

            void Dfs(int start)
            {
                if(start >= s.Length)
                {
                    result.Add(new List<string>(substrings));
                    return;
                }

                for (int end = start; end < s.Length; end++)
                {                    

                    if (CheckPalindrome(start, end))
                    {
                        substrings.Add(s.Substring(start, end - start + 1));

                        Dfs(end + 1);

                        substrings.RemoveAt(substrings.Count - 1);
                    }
                }
            }

            bool CheckPalindrome(int start, int end)
            {
                while (start < end)
                {
                    if (s[start] != s[end])
                        return false;
                    start++;
                    end--;
                }
                return true;
            }


            
        }
        
    }
}
