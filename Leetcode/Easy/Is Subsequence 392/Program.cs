/* Given two strings s and t, return true if s is a subsequence of t, or false otherwise.
A subsequence of a string is a new string that is formed from the original string by deleting 
some (can be none) of the characters without disturbing the relative positions of the remaining characters. 
(i.e., "ace" is a subsequence of "abcde" while "aec" is not).
*/

public class Solution
{
    public static void Main()
    {
        IsSubsequence("", "ahbgdc");
    }

    public static bool IsSubsequence(string s, string t)
    {
        if (s == "")
            return true;
        int j = 0;
        char cur = s[j];
        for (int i = 0; i < t.Length; i++)
        {
            if (t[i] == cur)
            {
                if(j != s.Length -1) 
                    cur = s[j + 1];
                j++;
            }
        }

        return j == s.Length;
    }
}