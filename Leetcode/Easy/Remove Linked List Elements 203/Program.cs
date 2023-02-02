/*
Given the head of a linked list and an integer val, remove all the nodes of the linked list that has Node.val == val, and return the new head.
*/

using System.Collections.ObjectModel;

public class Solution
{
    public static void Main()
    {
    }

    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int x)
        {
            val = x;
            next = null;
        }
    }

    public ListNode RemoveElements(ListNode head, int val)
    {
        ListNode prev = head;
        ListNode res = head;
        bool isFirst = true;
        while (head != null)
        {
            if (isFirst)
            {
                if (head.val == val)
                {
                    res = head.next;
                    prev = head.next;
                }
                else
                {
                    isFirst = false;
                }
            }
            else if (head.val == val)
            {
                prev.next = head.next;
            }
            else
            {
                prev = prev.next;
            }

            head = head.next;
        }

        return res;
    }
}