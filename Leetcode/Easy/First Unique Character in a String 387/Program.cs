/*
Given a string s, find the first non-repeating character in it and return its index. If it does not exist, return -1.
*/

using System.Collections.ObjectModel;

public class Solution
{
    public static void Main()
    {
    }

    public int FirstUniqChar(string s)
    {
        Dictionary<char, int> dict = new Dictionary<char, int>();
        foreach (var ch in s)
        {
            if(!dict.ContainsKey(ch))
                dict.Add(ch, 1);
            else
            {
                dict[ch]++;
            }
        }

        for (int i = 0; i < s.Length; i++)
        {
            if (dict[s[i]] == 1)
                return i;
        }

        return -1;
    }
}