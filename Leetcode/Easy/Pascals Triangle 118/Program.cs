/*
Given an integer numRows, return the first numRows of Pascal's triangle.
In Pascal's triangle, each number is the sum of the two numbers directly above it as shown:
*/

using System.Collections.ObjectModel;

public class Solution
{
    public static void Main()
    {
    }

    public IList<IList<int>> Generate(int numRows)
    {
        IList<IList<int>> result = new List<IList<int>>();
        List<int> first = new List<int>() { 1 };
        List<int> second = new List<int>() { 1, 1 };
        result.Add(first);
        if (numRows == 1)
            return result;
        result.Add(second);
        if (numRows == 2)
            return result;
        
        List<int> cur = second;
        for (int i = 2; i < numRows; i++)
        {
            List<int> next = new List<int>();
            next.Add(1);
            for (int j = 0; j < cur.Count - 1; j++)
            {
                next.Add(cur[j] + cur[j + 1]);
            }
            next.Add(1);
            cur = next;
            result.Add(next);
        }

        return result;
    }
}