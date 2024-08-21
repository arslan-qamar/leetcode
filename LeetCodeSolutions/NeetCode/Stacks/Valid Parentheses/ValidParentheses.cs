namespace LeetCodeSolutions.NeetCode.Valid_Parentheses
{
    public class ValidParentheses
    {
        public static bool IsValid(string s)
        {
            if (s.Length < 1)
            {
                return false;
            }

            Stack<char> validationStack = new Stack<char>();

            Dictionary<char, char> pairs = new Dictionary<char, char>()
            {
                [')'] = '(',
                ['}'] = '{',
                [']'] = '[',

            };

            foreach (char c in s)
            {

                if (c == '{' || c == '(' || c == '[')
                {
                    validationStack.Push(c);
                }

                if (pairs.ContainsKey(c))
                {
                    if (validationStack.Count == 0 || validationStack.Pop() != pairs[c])
                        return false;
                }
            }

            return validationStack.Count == 0;
        }
    }
}
