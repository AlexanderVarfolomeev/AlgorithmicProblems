/*
Given the head of a sorted linked list, delete all duplicates such that each element appears only once. Return the linked list sorted as well.
*/

public class Solution
{
    public static void Main()
    {
    }

    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public ListNode DeleteDuplicates(ListNode head)
    {
        ListNode n = head;
        while (head != null)
        {
            if (head.next is not null)
            {
                if (head.next.val == head.val)
                {
                    head.next = head.next.next;
                    continue;
                }
            
            }
            head = head.next;
        }

        return n;
    }
}

