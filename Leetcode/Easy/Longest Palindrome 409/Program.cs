/*
Given a string s which consists of lowercase or uppercase letters, return the length of the longest palindrome that can be built with those letters.

Letters are case sensitive, for example, "Aa" is not considered a palindrome here.
*/

public class Solution
{
    public static void Main()
    {
    }

    public int LongestPalindrome(string s)
    {
        Dictionary<char, int> dict = new Dictionary<char, int>();
        foreach (var ch in s)
        {
            if (dict.ContainsKey(ch))
            {
                dict[ch]++;
            }
            else
            {
                dict.Add(ch, 1);
            }
        }

        int result = 0;
        bool isOne = false;
        foreach (var ch in dict)
        {
            if (ch.Value % 2 == 0)
                result += ch.Value;
            else
            {
                result += ch.Value - 1;
                if (!isOne)
                {
                    result += 1;
                    isOne = true;
                }
            }
        }

        return result;
    }
}