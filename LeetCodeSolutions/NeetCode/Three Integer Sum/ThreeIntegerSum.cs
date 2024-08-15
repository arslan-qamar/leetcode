namespace LeetCodeSolutions.NeetCode.Three_Integer_Sum
{
    public class ThreeIntegerSum
    {

        public static List<List<int>> ThreeSumSol(int[] nums)
        {
            Array.Sort(nums);
            List<List<int>> res = new List<List<int>>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0) break;
                if (i > 0 && nums[i] == nums[i - 1]) continue;

                int l = i + 1, r = nums.Length - 1;
                while (l < r)
                {
                    int sum = nums[i] + nums[l] + nums[r];
                    if (sum > 0)
                    {
                        r--;
                    }
                    else if (sum < 0)
                    {
                        l++;
                    }
                    else
                    {
                        res.Add(new List<int> { nums[i], nums[l], nums[r] });
                        l++;
                        r--;
                        while (l < r && nums[l] == nums[l - 1])
                        {
                            l++;
                        }
                    }
                }
            }
            return res;
        }

        public static List<List<int>> ThreeSum(int[] nums)
        {
            Array.Sort(nums);
            List<List<int>> res = new List<List<int>>();

            HashSet<string> alreadyAdded = new HashSet<string>();

            for (int i = 0; i < nums.Length; i++)
            {
                int firstNumber = nums[i];
                int target = -firstNumber;
                int l = i + 1;
                int r = nums.Length - 1;

                for (; l < r && l < nums.Length;)
                {
                    int sum = nums[l] + nums[r];
                    if (sum == target)
                    {
                        if (!alreadyAdded.Contains($"{firstNumber}{nums[l]}{nums[r]}"))
                        {
                            alreadyAdded.Add($"{firstNumber}{nums[l]}{nums[r]}");
                            res.Add(new List<int>() { firstNumber, nums[l], nums[r] });
                        }

                        l++;
                        r--;
                    }

                    if (sum > target)
                    {
                        r--;
                    }

                    if (sum < target)
                    {
                        l++;
                    }
                }
            }

            return res;
        }

        private static int[]? findPossibleJK(int[] nums, int target, int i, List<List<int>> res)
        {
            int[]? jk = null;

            int l = i;
            int r = nums.Length - 1;

            for (; l < r && l < nums.Length;)
            {
                int sum = nums[l] + nums[r];

                if (sum == target)
                {
                    return new int[] { l, r };
                }

                if (sum > target)
                {
                    r--;
                }

                if (sum < target)
                {
                    l++;
                }

            }

            return jk;
        }
    }
}
