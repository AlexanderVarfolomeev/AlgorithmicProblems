/*
 * Given an array of integers nums which is sorted in ascending order, and an integer target, write a function to search target in nums.
 * If target exists, then return its index. Otherwise, return -1.
 * You must write an algorithm with O(log n) runtime complexity.
*/

using System.Collections.ObjectModel;

public class Solution
{
    public static void Main()
    {
        Search(new[] { -1, 0, 3, 5, 9, 12 }, 9);
    }

    public static int Search(int[] nums, int target)
    {
        int l = 0;
        int r = nums.Length - 1;

        while (l < r)
        {
            int m = (l + r) / 2;
            if (nums[m] == target)
            {
                return m;
            }

            if (nums[m] > target)
                r = m - 1;
            else
                l = m + 1;

        }

        if (nums[l] == target)
            return l;
        return -1;
    }
}