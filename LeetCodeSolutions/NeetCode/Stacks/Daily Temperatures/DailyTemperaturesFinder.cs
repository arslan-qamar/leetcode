namespace LeetCodeSolutions.NeetCode.Stacks.Daily_Temperatures
{
    public class DailyTemperaturesFinder
    {
        public static int[] DailyTemperatures(int[] temperatures)
        {
            int[] result = new int[temperatures.Length];

            LinkedList<int> monotonicStack = new LinkedList<int>();

            for (int i = 0; i < temperatures.Length; i++)
            {
                while (monotonicStack.Count > 0 && temperatures[monotonicStack.Last.Value] < temperatures[i])
                {
                    result[monotonicStack.Last.Value] = i - monotonicStack.Last.Value;
                    monotonicStack.RemoveLast();
                }

                monotonicStack.AddLast(i);
            }

            return result;
        }
    }
}
