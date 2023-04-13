/*
Given the head of a singly linked list, return the middle node of the linked list.
If there are two middle nodes, return the second middle node.
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

    public ListNode MiddleNode(ListNode head)
    {
        int count = 0;
        ListNode head2 = head;

        while (head2.next != null)
        {
            count++;
            head2 = head2.next;
        }

        count = count % 2 != 0 ? count / 2 + 1 : count / 2;
        while (count != 0)
        {
            head = head.next;
            count--;
        }

        return head;
    }
}