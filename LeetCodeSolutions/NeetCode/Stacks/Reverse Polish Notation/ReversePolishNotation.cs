namespace Reverse_Polish_Notation
{
    public class ReversePolishNotation
    {
        public static int EvalRPN(string[] tokens)
        {
            Stack<string> stack = new Stack<string>();

            for (int i = 0; i < tokens.Length; i++)
            {
                switch (tokens[i])
                {
                    case "+":
                        stack.Push(Convert.ToString(int.Parse(stack.Pop()) + int.Parse(stack.Pop())));
                        break;

                    case "*":
                        stack.Push(Convert.ToString(int.Parse(stack.Pop()) * int.Parse(stack.Pop())));
                        break;

                    case "-":
                        int firstPop = int.Parse(stack.Pop());
                        int secondPop = int.Parse(stack.Pop());
                        stack.Push(Convert.ToString(secondPop - firstPop));
                        break;

                    case "/":
                        firstPop = int.Parse(stack.Pop());
                        secondPop = int.Parse(stack.Pop());
                        stack.Push(Convert.ToString(secondPop / firstPop));
                        break;

                    default:
                        stack.Push(tokens[i]);
                        break;

                }
            }

            if (stack.Count == 1)
            {
                return int.Parse(stack.Pop());
            }
            else
            {
                return 0;
            }
        }
    }
}
