namespace LeetCodeSolutions.NeetCode.BackTracking.Permutation
{
    public class Permutations
    {
        public static List<List<int>> Permute(int[] nums)
        {
            List<List<int>> result = new List<List<int>>();

            result.Add(new List<int>());

            foreach (var n in nums)
            {
                List<List<int>> newPerm = new List<List<int>>();
                foreach (var perm in result)
                {
                    for (int i = 0; i <= perm.Count; i++)
                    {
                        List<int> perm_copy = new List<int>(perm);
                        perm_copy.Insert(i, n);
                        newPerm.Add(perm_copy);
                    }
                }
                result = newPerm;
            }
            return result;
        }

        public static List<List<int>> Permute2(int[] nums)
        {
            List<List<int>> result = new List<List<int>>() { new List<int>() };

            foreach (var n in nums)
            {
                result = result.SelectMany(perm => Enumerable.Range(0, perm.Count + 1)
                                            .Select(i =>
                                            {
                                                var newPerm = new List<int>(perm);
                                                newPerm.Insert(i, n);
                                                return newPerm;
                                            })).ToList();
            }

            return result;
        }

    }
}
