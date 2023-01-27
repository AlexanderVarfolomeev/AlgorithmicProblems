/*
 * Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.
 */
 
public class Solution {
    public static void Main() {}
    public bool ContainsDuplicate(int[] nums)
    {
        HashSet<int> set = new HashSet<int>();
        foreach (var num in nums)
        {
            set.Add(num);
        }

        return set.Count == nums.Length;
    }
}