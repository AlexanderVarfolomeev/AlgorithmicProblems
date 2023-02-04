/*
Given an m x n 2D binary grid grid which represents a map of '1's (land) and '0's (water), return the number of islands.
An island is surrounded by water and is formed by connecting adjacent lands horizontally or vertically. 
You may assume all four edges of the grid are all surrounded by water.
*/

public class Solution
{
    public static void Main()
    {
        char[][] arr = new[] { new char[] { '1', '1', '1' }, new[] { '0', '1', '0' }, new[] { '1', '1', '1' } };
        NumIslands(arr);
    }

    private static HashSet<(int, int)> islands = new HashSet<(int, int)>();

    public static int NumIslands(char[][] grid)
    {
        int cur = 0;
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[i].Length; j++)
            {
                if (grid[i][j] == '1' && !islands.Contains((i, j)))
                {
                    cur++;
                    BFS(grid, i, j);
                }
            }
        }

        return cur;
    }

    public static void BFS(char[][] grid, int i, int j)
    {
        if (grid[i][j] == '1' && !islands.Contains((i, j)))
        {
            islands.Add((i, j));
            if (i < grid.Length - 1)
                BFS(grid, i + 1, j);
            if (j < grid[i].Length - 1)
                BFS(grid, i, j + 1);
            if(i > 0)
                BFS(grid, i-1, j);
            if(j > 0)
                BFS(grid, i, j-1);
        }
    }
}