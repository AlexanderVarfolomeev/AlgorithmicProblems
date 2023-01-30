/*
In MATLAB, there is a handy function called reshape which can reshape an m x n matrix into a new one with a different size r x c keeping its original data.
You are given an m x n matrix mat and two integers r and c representing the number of rows and the number of columns of the wanted reshaped matrix.
The reshaped matrix should be filled with all the elements of the original matrix in the same row-traversing order as they were.
If the reshape operation with given parameters is possible and legal, output the new reshaped matrix; Otherwise, output the original matrix.
*/

public class Solution
{
    public static void Main()
    {
        MatrixReshape(new[]
        {
            new[] { 1, 2 },
            new[] { 3, 4 }
        },1,4);
    }

    public static int[][] MatrixReshape(int[][] mat, int r, int c) {


        Queue<int> list = new Queue<int>();
        foreach (var var in mat)
        {
            foreach (var i in var)
            {
                list.Enqueue(i);
            }
        }

        if (r * c != list.Count)
            return mat;
        int[][] arr = new int[r][];

        for (int i = 0; i < r; i++)
        {
            arr[i] = new int[c];
            for (int j = 0; j < c; j++)
            {
                arr[i][j] = list.Dequeue();
            }
        }

        return arr;
    }
}