/*
Given two strings s and t, return true if t is an anagram of s, and false otherwise.
An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.
*/

using System.Collections.ObjectModel;

public class Solution
{
    public static void Main()
    {
    }

    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
            return false;
        
        Dictionary<char, int> sDict = new Dictionary<char, int>();
        Dictionary<char, int> tDict = new Dictionary<char, int>();
        foreach (var ch in s)
        {
            if (tDict.ContainsKey(ch))
                tDict[ch]++;
            else
            {
                tDict.Add(ch, 1);
            }
        }

        foreach (var ch in t)
        {
            if (sDict.ContainsKey(ch))
                sDict[ch]++;
            else if (!tDict.ContainsKey(ch))
                return false;
            else 
            {
                sDict.Add(ch, 1);
            }
        }

        foreach (var val in sDict)
        {
            if (val.Value != tDict[val.Key])
                return false;
        }

        return true;
    }
}