/*
An image is represented by an m x n integer grid image where image[i][j] represents the pixel value of the image.

You are also given three integers sr, sc, and color. You should perform a flood fill on the image starting from the pixel image[sr][sc].

To perform a flood fill, consider the starting pixel, plus any pixels connected 4-directionally to the starting pixel of the same color as the starting pixel, 
plus any pixels connected 4-directionally to those pixels (also with the same color), and so on. Replace the color of all of the aforementioned pixels with color.

Return the modified image after performing the flood fill.
*/

public class Solution
{
    public static void Main()
    {
    }

    public int[][] FloodFill(int[][] image, int sr, int sc, int color)
    {
        Flood(image, sr, sc, color, image[sr][sc]);
        return image;
    }

    public void Flood(int[][] image, int i, int j, int color, int startColor)
    {
        if(image[i][j] == color)
            return;
        if (image[i][j] == startColor)
        {
            image[i][j] = color;
            if(i < image.Length - 1)
                Flood(image, i + 1, j, color, startColor);
            if(j < image[i].Length - 1)
                Flood(image, i, j + 1, color, startColor);
            if(i > 0)
                Flood(image, i - 1, j, color, startColor);
            if(j > 0)
                Flood(image, i, j - 1, color, startColor);
        }
    }
}