namespace LeetCodeSolutions.NeetCode.Stacks.Generate_Parentheses
{
    public class GenerateParentheses
    {
        public static List<string> GenerateParenthesis(int n)
        {

            List<string> result = new List<string>();

            if (n < 1 || n > 7)
            {
                return result;
            }

            // if openC == closeC == n, return result
            // if openC < n , append (
            // if closeC < openC, append )

            Stack<char> stack = new Stack<char>();

            void backTrack(int openC, int closeC)
            {
                if (openC == closeC && closeC == n)
                {
                    result.Add(string.Join("", stack.Reverse()));
                    return;
                }

                if (openC < n)
                {
                    stack.Push('(');
                    backTrack(openC + 1, closeC);
                    stack.Pop();
                }

                if (closeC < openC)
                {
                    stack.Push(')');
                    backTrack(openC, closeC + 1);
                    stack.Pop();
                }

            }

            backTrack(0, 0);

            return result;
        }

    }
}
