/* Given two strings s and t, determine if they are isomorphic.
Two strings s and t are isomorphic if the characters in s can be replaced to get t.
All occurrences of a character must be replaced with another character while preserving the order of characters. 
No two characters may map to the same character, but a character may map to itself.
*/

public class Solution {
    public static void Main()
    {
    }
    
    public  bool IsIsomorphic(string s, string t)
    {
        Dictionary<char, int> set1 = new Dictionary<char, int>();
        Dictionary<char, int> set2 = new Dictionary<char, int>();
        string first = "", second ="";
        
        foreach (var sym in s)
        {
            if (!set1.ContainsKey(sym))
            {
                set1.Add(sym, set1.Count + 1);
            }
            first += set1[sym];

        }
        
        foreach (var sym in t)
        {
            if (!set2.ContainsKey(sym))
            {
                set2.Add(sym, set2.Count + 1);
            }
            second += set2[sym];
        }

        return first == second;
    }
}