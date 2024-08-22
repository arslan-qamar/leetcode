using System.Collections.Immutable;

namespace Top_K_Frequent
{
    public class TopKFrequentFinder
    {
        public static int[] TopKFrequent(int[] nums, int k)
        {
            Dictionary<int, int> numCount = new Dictionary<int, int>();

            List<int> result = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int number = nums[i];

                if (numCount.Keys.Contains(number))
                {
                    numCount[number] = ++numCount[number];
                }
                else
                {
                    numCount.Add(number, 1);
                }
            }

            List<int>[] countMap = new List<int>[nums.Length + 1];

            foreach (KeyValuePair<int, int> item in numCount)
            {
                if (countMap[item.Value] == null)
                {
                    countMap[item.Value] = new List<int>() { item.Key };
                }
                else
                {
                    countMap[item.Value].Add(item.Key);
                }

            }


            for (int i = nums.Length; i > 0; i--)
            {
                if (countMap[i] != null && countMap[i].Count > 0)
                {
                    result.AddRange(countMap[i].Take(k - result.Count).ToArray());
                }

                if (result.Count == k)
                {
                    break;
                }
            }

            return result.ToArray();
        }
    }
}
