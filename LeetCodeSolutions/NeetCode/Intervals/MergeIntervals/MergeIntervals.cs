namespace LeetCodeSolutions.NeetCode.Intervals.MergeIntervals
{
    public class MergeIntervals
    {
        public static int[][] Merge(int[][] intervals)
        {
            Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));

            List<int[]> output = new List<int[]>();

            output.Add(intervals[0]);

            for (int i = 1; i < intervals.Length; i++)
            {

                var value = intervals[i];

                if (output.Last()[1] >= value[0])
                {
                    output.Last()[1] = Math.Max(output.Last()[1], value[1]);
                }
                else
                {
                    output.Add(value);
                }
            }

            return output.ToArray();
        }
    }
}
