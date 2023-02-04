/*
Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

An input string is valid if:

    Open brackets must be closed by the same type of brackets.
    Open brackets must be closed in the correct order.
    Every close bracket has a corresponding open bracket of the same type.
*/

public class Solution
{
    public static void Main()
    {
    }

    public bool IsValid(string s)
    {
        Stack<char> stack = new Stack<char>();
        foreach (var ch in s)
        {
            if (stack.Count != 0)
            {
                if (ch == ')')
                {
                    if (stack.Peek() == '(')
                    {
                        stack.Pop();
                        continue;
                    }
                }

                if (ch == '}')
                {
                    if (stack.Peek() == '{')
                    {
                        stack.Pop();
                        continue;
                    }
                }

                if (ch == ']')
                {
                    if (stack.Peek() == '[')
                    {
                        stack.Pop();
                        continue;
                    }
                }
            }

            stack.Push(ch);
        }

        return stack.Count == 0;
    }
}