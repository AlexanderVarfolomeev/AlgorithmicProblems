/* Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
You may assume that each input would have exactly one solution, and you may not use the same element twice.
You can return the answer in any order.
*/

public class Solution
{
    public static void Main()
    {
    }
    
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (dict.ContainsKey(target - nums[i]))
                return new[] { dict[target - nums[i]], i };
            
            if(!dict.ContainsKey(nums[i]))
                dict.Add(nums[i], i);
        }

        return new[] {0,0};
    }
}