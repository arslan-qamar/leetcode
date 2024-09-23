namespace LeetCodeSolutions.NeetCode.BackTracking.CombinationSum
{
    public class CombinationSumFinder
    {
        public static List<List<int>> CombinationSum(int[] nums, int target)
        {
            List<List<int>> result = new List<List<int>>();

            List<int> combination = new List<int>();

            FindCombinations(0, 0);

            void FindCombinations(int index, int currSum)
            {                
                if (currSum == target)
                {
                    result.Add(new List<int>(combination));
                    return;
                }

                if (index >= nums.Length || currSum > target)
                {
                    return;
                }

                combination.Add(nums[index]);
                currSum += nums[index];
                FindCombinations(index, currSum);
                
                combination.RemoveAt(combination.Count - 1);
                currSum -= nums[index];
                FindCombinations(index + 1, currSum);
                
            }

            return result;
        }

    }
}
