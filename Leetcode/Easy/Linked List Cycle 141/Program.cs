/*
Given head, the head of a linked list, determine if the linked list has a cycle in it.

There is a cycle in a linked list if there is some node in the list that can be reached again by continuously following the next pointer. 
Internally, pos is used to denote the index of the node that tail's next pointer is connected to. Note that pos is not passed as a parameter.

Return true if there is a cycle in the linked list. Otherwise, return false.


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

    public bool HasCycle(ListNode head)
    {
        ListNode fast = head;
        ListNode slow = head;
        while ( fast != null || fast.next != null )
            
        {
            fast = fast.next.next;
            slow = slow.next;

            if (slow == fast)
                return true;
        }

        return false;
    }
}