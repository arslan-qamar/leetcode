namespace Extras.Problem_3
{
    public class MedianAnalysis
    {
        public static List<int> getMaxSubsequenceLen(List<int> arr)
        {
            // Step 1: Calculate the frequency of each element in arr
            Dictionary<int, int> freq = [];
            foreach (int i in arr)
            {
                if (!freq.ContainsKey(i))
                    freq[i] = 0;
                freq[i]++;
            }

            // Step 2: Sort the unique elements in arr
            int[] sortedArr = freq.Keys.OrderBy(x => x).ToArray();

            // K[x] will hold the minimum of elements smaller or greater than x
            Dictionary<int, int> K = [];
            for (int idx = 0; idx < sortedArr.Length; idx++)
            {
                int x = sortedArr[idx];
                int numSmallerThanX = idx;
                int numGreaterThanX = sortedArr.Length - idx - 1;
                K[x] = Math.Min(numSmallerThanX, numGreaterThanX);
            }

            // Step 3: Precompute the sum of frequencies for elements smaller than x
            Dictionary<int, int> sumOfElementsSmallerThanX = [];
            PriorityQueue<int, int> minHeap = new PriorityQueue<int, int>();
            int totalSum = 0;

            foreach (int x in sortedArr)
            {
                if (minHeap.Count <= K[x])
                {
                    sumOfElementsSmallerThanX[x] = totalSum;
                }
                else
                {
                    while (minHeap.Count > K[x])
                    {
                        totalSum -= minHeap.Dequeue();
                    }
                    sumOfElementsSmallerThanX[x] = totalSum;
                }

                minHeap.Enqueue(freq[x], freq[x]);
                totalSum += freq[x];
            }

            // Step 4: Precompute the sum of frequencies for elements greater than x
            Dictionary<int, int> sumOfElementsGreaterThanX = [];
            minHeap.Clear();
            totalSum = 0;

            for (int i = sortedArr.Length - 1; i >= 0; i--)
            {
                int x = sortedArr[i];

                if (minHeap.Count <= K[x])
                {
                    sumOfElementsGreaterThanX[x] = totalSum;
                }
                else
                {
                    while (minHeap.Count > K[x])
                    {
                        totalSum -= minHeap.Dequeue();
                    }
                    sumOfElementsGreaterThanX[x] = totalSum;
                }

                minHeap.Enqueue(freq[x], freq[x]);
                totalSum += freq[x];
            }

            // Step 5: Compute the maximum subsequence length for each element in arr
            Dictionary<int, int> ans = [];
            foreach (int x in sortedArr)
            {
                int lower = sumOfElementsSmallerThanX[x];
                int greater = sumOfElementsGreaterThanX[x];
                int equal = freq[x];

                // The maximum length is the number of balanced smaller/greater pairs, plus the frequency of x
                // Number of elements greater than x in the optimal subsequence
                ans[x] = 2 * Math.Min(lower, greater) + equal + Math.Min(Math.Abs(lower - greater), equal);

                if (ans[x] % 2 == 0)
                {
                    ans[x] = ans[x] - 1;
                }
            }

            // Return the adjusted result for each element in the array
            return arr.Select(i => ans[i]).ToList();

        }


    }
}
