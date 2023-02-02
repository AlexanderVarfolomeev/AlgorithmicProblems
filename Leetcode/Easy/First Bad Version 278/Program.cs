/*
You are a product manager and currently leading a team to develop a new product. 
Unfortunately, the latest version of your product fails the quality check. 
Since each version is developed based on the previous version, all the versions after a bad version are also bad.

Suppose you have n versions [1, 2, ..., n] and you want to find out the first bad one, which causes all the following ones to be bad.

You are given an API bool isBadVersion(version) which returns whether version is bad. Implement a function to find the first bad version. 
You should minimize the number of calls to the API.
*/

using System.Collections.ObjectModel;

public class Solution
{
    public static void Main()
    {
        FirstBadVersion(2126753390);
    }

    public static int n = 1702766719;
    public static bool IsBadVersion(int version)
    {
        return version >= n;
    }
    public static int FirstBadVersion(int n) {
        int l = 0;
        int r = n - 1;
        int bad = -1;
        bool isBad = false;
        while (l < r)
        {
            int m = Convert.ToInt32((Convert.ToUInt32(l) + Convert.ToUInt32(r)) / 2);
            isBad = IsBadVersion(m);
            if (isBad)
            {
                bad = m;
                r = m - 1;
            }

            if (!isBad)
            {
                l = m + 1;
            }

        }

        if (isBad)
            return l;
        return bad;
    }
}