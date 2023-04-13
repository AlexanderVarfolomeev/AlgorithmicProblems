/*
Given a string s, find the length of the longest substring without repeating characters.
 */

public class Solution
{
    public static void Main()
    {
    }

    public int LengthOfLongestSubstring(string s)
    {
        int max = 0;
        int curMax = 0;
        Dictionary<char, int> set = new Dictionary<char, int>();
        for (int i = 0; i < s.Length; i++)
        {
            if (set.ContainsKey(s[i]))
            {
                if (curMax > max)
                    max = curMax;
                curMax = 1;
                i = set[s[i]] + 1;
                set = new Dictionary<char, int>();
            }
            else
            {
                curMax++;
            }

            set.Add(s[i], i);
        }
        return Math.Max(max, curMax);
    }
}