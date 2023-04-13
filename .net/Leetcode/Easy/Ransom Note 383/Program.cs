/*
Given two strings ransomNote and magazine, return true if ransomNote can be constructed by using the letters from magazine and false otherwise.
Each letter in magazine can only be used once in ransomNote.
*/

using System.Collections.ObjectModel;

public class Solution
{
    public static void Main()
    {
    }

    public bool CanConstruct(string ransomNote, string magazine)
    {
        Dictionary<char, int> ransDict = new Dictionary<char, int>();
        Dictionary<char, int> magazDict = new Dictionary<char, int>();
        foreach (var ch in magazine)
        {
            if (magazDict.ContainsKey(ch))
                magazDict[ch]++;
            else
            {
                magazDict.Add(ch, 1);
            }
        }

        foreach (var ch in ransomNote)
        {
            if (ransDict.ContainsKey(ch))
                ransDict[ch]++;
            else
            {
                ransDict.Add(ch, 1);
            }
        }

        foreach (var ch in ransDict)
        {
            if (!magazDict.ContainsKey(ch.Key))
                return false;
            else if (ch.Value > magazDict[ch.Key])
                return false;
        }

        return true;
    }
}