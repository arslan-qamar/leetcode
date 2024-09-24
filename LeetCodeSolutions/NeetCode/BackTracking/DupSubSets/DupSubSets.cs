namespace LeetCodeSolutions.NeetCode.BackTracking.DupSubSets
{
    public  class DupSubSets
    {
        public static List<List<int>> SubsetsWithDup(int[] nums)
        {
            List<List<int>> result = new List<List<int>>();

            Array.Sort(nums);

            List<int> subSet = new List<int>();
            CreateSubSets(0);

            void CreateSubSets(int index)
            {
                if (index >= nums.Length)
                {
                    result.Add(new List<int>(subSet));
                    return;
                }

                
                subSet.Add(nums[index]);                
                CreateSubSets(index + 1);
                subSet.RemoveAt(subSet.Count - 1);


                while (index + 1 < nums.Length && nums[index] == nums[index + 1])
                {
                    index++;
                }

                CreateSubSets(index + 1);
            }

            return result;
        }
    }
}
