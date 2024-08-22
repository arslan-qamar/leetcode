namespace Product_Exclude_Self
{
    public class ProductExcludeSelf
    {
        public static int[] ProductExceptSelf(int[] nums)
        {
            int[] result = new int[nums.Length];

            int[] preProd = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                if (i == 0)
                {
                    preProd[i] = 1;
                    continue;
                }

                preProd[i] = nums[i - 1] * preProd[i - 1];
            }

            int[] postProd = new int[nums.Length];
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                if (i == nums.Length - 1)
                {
                    postProd[i] = 1;
                    continue;
                }

                postProd[i] = nums[i + 1] * postProd[i + 1];
            }


            for (int i = 0; i < nums.Length; i++)
            {
                result[i] = preProd[i] * postProd[i];
            }


            return result;
        }

    }
}
