/*
You are climbing a staircase. It takes n steps to reach the top.
Each time you can either climb 1 or 2 steps. In how many distinct ways can you climb to the top?
*/

public class Solution
{
    public static void Main()
    {
    }

    private Dictionary<int, int> nth = new Dictionary<int, int>();
    public int ClimbStairs(int n)
    {
        if (nth.ContainsKey(1))
        {
            nth.Add(1, 1);
            nth.Add(2, 2);
        }

        if (n == 1)
            return 1;
        if (n == 2)
            return 2;
        nth.Add(n, ClimbStairs(n - 1) + nth[n - 2]);
        return nth[n];
    }
  
}