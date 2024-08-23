namespace LeetCodeSolutions.NeetCode.Binary_Search.TimeMap
{
    public class TimeMap
    {
        private readonly Dictionary<string, List<(int TimeStamp, string Value)>> keyValuePairs;

        public TimeMap()
        {
            keyValuePairs = new Dictionary<string, List<(int TimeStamp, string Value)>>();
        }

        public void Set(string key, string value, int timestamp)
        {
            keyValuePairs[key] = keyValuePairs.TryGetValue(key, out List<(int TimeStamp, string Value)> storedValues) ? storedValues : new List<(int TimeStamp, string Value)>();
            keyValuePairs[key].Add((timestamp, value));
        }

        public string Get(string key, int timestamp)
        {
            string result = "";

            if (keyValuePairs.ContainsKey(key))
            {

                List<(int TimeStamp, string Value)> values = keyValuePairs[key];
                int left = 0, right = values.Count - 1;


                while (left <= right)
                {
                    int mid = left + (right - left) / 2;
                    if (values[mid].TimeStamp <= timestamp)
                    {
                        result = values[mid].Item2;
                        left = mid + 1;
                    }
                    else
                    {
                        right = mid - 1;
                    }
                }
            }

            return result;


        }

    }
}
