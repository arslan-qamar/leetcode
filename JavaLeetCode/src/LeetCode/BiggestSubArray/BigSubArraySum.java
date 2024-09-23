package LeetCode.BiggestSubArray;

import java.util.Arrays;

public class BigSubArraySum {


    public static int getSubArraySumLength(int[] nums , int k) {
        int result = 0;
        int currSum = Arrays.stream(nums).sum();

        int i = 0;
        int j = nums.length - 1;

        while(i < j) {
            if (currSum <= k) {
                result = j - i + 1;
                break;
            }

            if (nums[i] > nums[j]) {
                currSum -= nums[i];
                i++;

            } else {
                currSum -= nums[j];
                j--;
            }
        }

        return result;
    }
}
