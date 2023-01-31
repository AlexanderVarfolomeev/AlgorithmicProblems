/*
Given a signed 32-bit integer x, return x with its digits reversed. 
If reversing x causes the value to go outside the signed 32-bit integer range [-231, 231 - 1], then return 0.

Assume the environment does not allow you to store 64-bit integers (signed or unsigned).
 */

public class Solution
{
    public static void Main()
    {
        Console.WriteLine(Reverse(-2147483648));
    }

    public static int Reverse(int x)
    {
        bool isNeg = x < 0;
        string s = x.ToString();

        if (isNeg)
        {
            s = s.Substring(1);
        }

        if (x == 0)
            return 0;

        s = String.Join("", s.Reverse());
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] != '0')
                break;
        }


        string max = isNeg ? "2147483648" : "2147483647";
        //2147483412
        int[] maxArr = max.Reverse().Reverse().Select(x => int.Parse(x.ToString())).ToArray();
        int[] numArr = s.Select(x => int.Parse(x.ToString())).ToArray();
        if (numArr.Length > maxArr.Length)
        {
            return 0;
        }

        bool isMax = false;
        if (numArr.Length == maxArr.Length)
        {
            for (int i = 0; i < maxArr.Length; i++)
            {
                if (maxArr[i] == numArr[i])
                {
                    if (i == maxArr.Length - 1)
                        isMax = true;
                    continue;
                }

                if (numArr[i] < maxArr[i])
                    break;
                if (numArr[i] > maxArr[i])
                    return 0;
            }
        }


        return isNeg
            ? isMax ? int.MinValue : int.Parse(s) * -1
            : int.Parse(s);
    }
}   