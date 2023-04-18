/*
 * Given an integer array nums, find the subarray with the largest sum, and return its sum.
 */

//Kadane's algorithm
public class Solution {
    public static void Main() {}
    public int MaxSubArray(int[] nums)
    {
        int curSum = nums[0], maxSum = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            curSum = Math.Max(curSum + nums[i], nums[i]);
            maxSum = Math.Max(curSum, maxSum);
        }
        return maxSum;
    }

  
}