namespace Extras.Problem_1
{
    public static class DegreeArray
    {
        public static int degreeOfArray(List<int> arr)
        {
            if (arr == null || arr.Count == 0)
            {
                return 0;
            }

            int degree = arr.Count;

            Dictionary<int, int> freq = [];
            Dictionary<int, (int startIndex, int endIndex)> startEnd = [];

            int maxOccurence = 0;

            for (int i = 0; i < arr.Count; i++)
            {
                int num = arr[i];

                freq[num] = freq.TryGetValue(num, out int frequency) ? ++frequency : 1;

                maxOccurence = Math.Max(maxOccurence, freq[num]);

                if (!startEnd.ContainsKey(num))
                {
                    startEnd[num] = (i, i);
                }
                else
                {
                    startEnd[num] = (startEnd[num].startIndex, i);
                }
            }

            foreach (KeyValuePair<int, int> kv in freq)
            {
                if (maxOccurence == kv.Value)
                {
                    degree = Math.Min(degree, startEnd[kv.Key].endIndex - startEnd[kv.Key].startIndex + 1);
                }
            }

            return degree;
        }
    }
}
