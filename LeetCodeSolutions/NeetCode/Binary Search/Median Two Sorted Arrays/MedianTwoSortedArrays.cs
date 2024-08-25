namespace Binary_Search.Median_Two_Sorted_Arrays
{
    public class MedianTwoSortedArrays
    {

        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            if (nums1.Length > nums2.Length)
            {
                return FindMedianSortedArrays(nums2, nums1);
            }

            int l = 0;
            int r = nums1.Length;
            int half = (nums1.Length + nums2.Length + 1) / 2;

            while (l <= r)
            {
                int mid1 = (l + r) / 2;
                int mid2 = half - mid1;

                // If mid1 is 0, it means nothing is there on the left side. Use  int.MinValue for maxLeft1
                // If mid1 is length of nums1 input then there is nothing on the right side. Use int.MaxValue for minRight1
                int maxLeft1 = (mid1 == 0) ? int.MinValue : nums1[mid1 - 1];
                int minRight1 = (mid1 == nums1.Length) ? int.MaxValue : nums1[mid1];

                int maxLeft2 = (mid2 == 0) ? int.MinValue : nums2[mid2 - 1];
                int minRight2 = (mid2 == nums2.Length) ? int.MaxValue : nums2[mid2];

                if (maxLeft1 <= minRight2 && maxLeft2 <= minRight1)
                {
                    // We have partitioned array at the correct place
                    // Now get max of left elements and min of right elements to get the median in case of even length combined array size
                    // or get max of left for odd length combined array size.
                    if ((nums1.Length + nums2.Length) % 2 == 0)
                    {
                        return ((double)Math.Max(maxLeft1, maxLeft2) + Math.Min(minRight1, minRight2)) / 2;
                    }
                    else
                    {
                        return Math.Max(maxLeft1, maxLeft2);
                    }
                }
                else if (maxLeft1 > minRight2)
                { // We are too far on the right side for mid1. Go on the left side.
                    r = mid1 - 1;
                }
                else
                { // We are too far on the left side for mid1. Go on the right side.
                    l = mid1 + 1;
                }
            }

            throw new Exception("Input array are not sorted");
        }
    }
}
