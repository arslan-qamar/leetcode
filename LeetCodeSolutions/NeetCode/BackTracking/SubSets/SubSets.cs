namespace LeetCodeSolutions.NeetCode.BackTracking
{
    public class SubSets
    {
        public static List<List<int>> Subsets(int[] nums)
        {
            List<List<int>> result = new List<List<int>>();

            List<int> subSets = new List<int>();
            CreateSubSets(0);

            void CreateSubSets(int index)
            {
                if (index >= nums.Length)
                {
                    result.Add(new List<int>(subSets));
                    return;
                }

                subSets.Add(nums[index]);
                CreateSubSets(index + 1);

                subSets.RemoveAt(subSets.Count - 1);
                CreateSubSets(index + 1);
            }


            return result;
        }
    }
}
