namespace LeetCodeSolutions.NeetCode.Min_Stack
{
    public class MinStack
    {
        private readonly LinkedList<Tuple<int, int>> stack;
        private int currentMin = int.MaxValue;
        public MinStack()
        {
            stack = new LinkedList<Tuple<int, int>>();
        }

        public void Push(int val)
        {
            if (val < currentMin)
            {
                currentMin = val;
            }

            stack.AddFirst(new LinkedListNode<Tuple<int, int>>(new Tuple<int, int>(val, currentMin)));
        }

        public void Pop()
        {
            if (stack.Count > 0)
            {
                stack.RemoveFirst();

                if (stack.Count == 0)
                {
                    currentMin = int.MaxValue;
                }
                else if (stack.First.Value.Item2 > currentMin)
                {
                    currentMin = stack.First.Value.Item2;
                }
            }
        }

        public int Top()
        {
            if (stack.Count > 0)
            {
                return stack.First.Value.Item1;
            }

            return int.MinValue;
        }

        public int GetMin()
        {
            if (stack.Count > 0)
            {
                return stack.First.Value.Item2;
            }

            return currentMin;
        }
    }
}
