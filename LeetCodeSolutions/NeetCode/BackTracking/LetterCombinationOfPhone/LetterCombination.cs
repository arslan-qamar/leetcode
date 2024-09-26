
using System.Text;

namespace LeetCodeSolutions.NeetCode.BackTracking.LetterCombinationOfPhone
{
    public class LetterCombination
    {

        public List<string> LetterCombinations(string digits)
        {
            List<string> result = new List<string>();                      

            Dictionary<int, char[]> CharMap = new Dictionary<int, char[]>()
            {
                {'2', new char[]{'a', 'b', 'c' } },
                {'3', new char[]{'d', 'e', 'f' } },
                {'4', new char[]{'g', 'h', 'i' } },
                {'5', new char[]{'j', 'k', 'l' } },
                {'6', new char[]{'m', 'n', 'o' } },
                {'7', new char[]{'p', 'q', 'r', 's' } },
                {'8', new char[]{'t', 'u', 'v' } },
                {'9', new char[]{'w', 'x', 'y', 'z' } }
            };

            StringBuilder combination = new StringBuilder();

            Dfs(0);


            void Dfs(int index){

                if(combination.Length == digits.Length)
                {
                    result.Add(combination.ToString());                    
                    return;
                }

                foreach (var c in CharMap[digits[index]])
                {
                    combination.Append(c);
                    Dfs(index + 1);
                    combination.Remove(combination.Length - 1, 1);
                }
            }

            return result;
        }

       
        
    }
}
