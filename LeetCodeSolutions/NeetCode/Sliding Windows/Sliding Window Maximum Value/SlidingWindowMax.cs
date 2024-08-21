namespace LeetCodeSolutions.NeetCode.Sliding_Window_Maximum_Value
{
    public class SlidingWindowMax
    {
        public static int[] MaxSlidingWindow(int[] nums, int k)
        {
            if (k < 1 || nums == null || nums.Length < k)
            {
                return new int[0];
            }

            int[] output = new int[nums.Length - k + 1];

            int n = nums.Length;

            LinkedList<int> q = new LinkedList<int>();

            int l = 0, r = 0;

            while (r < n)
            {
                while (q.Count > 0 && nums[q.Last.Value] < nums[r])
                {
                    q.RemoveLast();
                }

                q.AddLast(r);

                if (r + 1 >= k)
                {
                    output[l] = nums[q.First.Value];
                    l++;
                }

                if (l > q.First.Value)
                {
                    q.RemoveFirst();
                }

                r++;
            }

            return output;
        }
    }
}
