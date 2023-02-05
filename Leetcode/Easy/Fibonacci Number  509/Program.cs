/*
The Fibonacci numbers, commonly denoted F(n) form a sequence, 
called the Fibonacci sequence, such that each number is the sum of the two preceding ones, starting from 0 and 1. That is,
*/

public class Solution
{
    public static void Main()
    {
    }
    public int Fib(int n)
    {
        if (n is 0)
            return 0;
        if (n is 1)
            return 1;
        return Fib(n - 1) + Fib(n - 2);
    }
  
}