/*
You are given an m x n integer matrix matrix with the following two properties:

    Each row is sorted in non-decreasing order.
    The first integer of each row is greater than the last integer of the previous row.

Given an integer target, return true if target is in matrix or false otherwise.

You must write a solution in O(log(m * n)) time complexity.
*/


//cringe solution
public class Solution
{
    public static void Main()
    {
        int[][] arr = new[] { new[] { 1, 3, 5, 7 }, new[] { 10, 11, 16, 20 }, new[] { 23, 30, 34, 60 } };
        int[][] ar1 = new[]
        {
            new[] { -10, -10 }, new[] { -9, -9 }, new[] { -8, -6 }, new[] { -4, -2 }, new[] { 0, 1 }, new[] { 3, 3 },
            new[] { 5, 5 }, new[] { 6, 8 }
        };
        SearchMatrix(ar1, 0);
    }

    public static bool SearchMatrix(int[][] matrix, int target)
    {
        int left = 0;
        int right = matrix.Length - 1;
        int med = right / 2;

        while (med != 0)
        {
            int val = matrix[med + left][0];
            if (val == target) 
                return true;
            if (val > target)
            {
                right -= med;
            }
            else if (val < target)
            {
                left += med;
            }

            med = (right - left) / 2;
        }

        if (matrix[right][0] == target)
            return true;
        if (matrix[right][0] < target)
            left = right;

        int cur = left;
        left = 0;
        right = matrix[0].Length - 1;
        med = right / 2;
        if (med == 0 && (matrix[cur][right] == target || matrix[cur][left] == target))
            return true;
        while (med != 0)
        {
            int val = matrix[cur][med + left];
            if (val == target)
                return true;
            if (val > target)
            {
                right -= med;
            }
            else if (val < target)
            {
                left += med;
            }

            med = (right - left) / 2;
        }

        if ((matrix[cur][right] == target || matrix[cur][left] == target))
            return true;

        return false;
    }
}