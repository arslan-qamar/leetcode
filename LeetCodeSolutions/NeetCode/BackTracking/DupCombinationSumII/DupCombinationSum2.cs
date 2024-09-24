namespace LeetCodeSolutions.NeetCode.BackTracking.DupCombinationSumII
{
    public class DupCombinationSum2
    {
        public static List<List<int>> CombinationSum2(int[] candidates, int target)
        {
            List<List<int>> result = new List<List<int>>();

            Array.Sort(candidates);

            List<int> combination = new List<int>();

            FindCombination(0, 0);

            void FindCombination(int index, int sum)
            {
                if(sum == target)
                {
                    result.Add(new List<int>(combination));
                    return;
                }

                if(index >= candidates.Length || sum > target)
                {
                    return;
                }

                sum += candidates[index];
                combination.Add(candidates[index]);
                FindCombination(index + 1, sum);


                combination.RemoveAt(combination.Count - 1);
                sum -= candidates[index];


                while(index + 1 < candidates.Length && candidates[index] == candidates[index + 1])
                {
                    index++;
                }

                FindCombination(index + 1, sum);
            }

            return result;

        }

    }
}
