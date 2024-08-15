namespace LeetCodeSolutions.NeetCode.Longest_Consecutive_Sequence
{
    public class LongestConsecutiveNumber
    {
        public static int LongestConsecutive(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return 0;
            }

            HashSet<int> numSet = GetNumSet(nums);

            int[] sequenceStarts = FindSequences(nums, numSet);

            int maxSequence = 1;
            foreach (int sequenceStart in sequenceStarts)
            {
                int currentMax = 1;
                int nextValue = sequenceStart + 1;
                while (numSet.Contains(nextValue))
                {
                    currentMax++;
                    if (currentMax > maxSequence)
                    {
                        maxSequence = currentMax;
                    }

                    nextValue++;
                }
            }

            return maxSequence;
        }

        private static HashSet<int> GetNumSet(int[] nums)
        {
            HashSet<int> numSet = new HashSet<int>(nums);
            return numSet;
        }

        private static int[] FindSequences(int[] nums, HashSet<int> numSet)
        {
            List<int> sequence = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int number = nums[i];
                if (!numSet.Contains(number - 1))
                {
                    sequence.Add(number);
                }
            }

            return sequence.ToArray();
        }
    }
}
