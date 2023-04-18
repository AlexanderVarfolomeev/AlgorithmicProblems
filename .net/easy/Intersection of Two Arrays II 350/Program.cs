/*
Given two integer arrays nums1 and nums2, return an array of their intersection. 
Each element in the result must appear as many times as it shows in both arrays and you may return the result in any order.
 */

public class Solution
{
    public static void Main()
    {
        Intersect(new[] { 4, 5, 9 }, new[] { 4, 4, 8, 9, 9 });
    }

    public static int[] Intersect(int[] nums1, int[] nums2)
    {
        Array.Sort(nums1);
        Array.Sort(nums2);

        List<int> res = new List<int>();
        
        int i = 0;
        int j = 0;

        while (i != nums1.Length && j != nums1.Length)
        {
            if (nums1[i] == nums2[j])
            {
                res.Add(nums1[i++]);
                j++;
            }
            else if (nums1[i] < nums2[j])
            {
                i++;
            }
            else if (nums2[j] < nums1[i])
            {
                j++;
            }
        }

        return res.ToArray();
    }
}