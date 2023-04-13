namespace Running_Sum_of_1d_Array_1480;

/// <summary>
/// Given an array nums. We define a running sum of an array as runningSum[i] = sum(nums[0]…nums[i]).
/// Return the running sum of nums.
/// </summary>
public class Solution {
    public static void Main() {}
    
    public int[] RunningSum(int[] nums)
    {
        int[] running = new int[nums.Length];
        running[0] = nums[0];

        for (int i = 1; i < nums.Length; i++)
        {
            running[i] = nums[i] + running[i - 1];
        }

        return running;
    }
}