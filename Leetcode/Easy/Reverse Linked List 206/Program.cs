/*
Given the head of a singly linked list, reverse the list, and return the reversed list.
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

    public ListNode ReverseList(ListNode head)
    {
        if (head is null)
            return null;
        
        ListNode result = new ListNode(head.val);
        head = head.next;
        
        while (head is not null)
        {
            ListNode cur = new ListNode(head.val, result);
            head = head.next;
            result = cur;
        }

        return result;
    }
}