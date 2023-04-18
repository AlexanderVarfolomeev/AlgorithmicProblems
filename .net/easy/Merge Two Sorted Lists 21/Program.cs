/*
You are given the heads of two sorted linked lists list1 and list2.
Merge the two lists in a one sorted list. The list should be made by splicing together the nodes of the first two lists.
Return the head of the merged linked list.
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

    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        ListNode result = new ListNode();
        ListNode head = result;

        while (list1 is not null || list2 is not null)
        {
            if (list1 is null)
            {
                result.next = list2;
                list2 = list2.next;
            }
            else if (list2 is null)
            {
                result.next = list1;
                list1 = list1.next;
            }
            else if (list1.val <= list2.val)
            {
                result.next = list1;
                list1 = list1.next;
            }
            else
            {
                result.next = list2;
                list2 = list2.next;
            }

            result = result.next;
        }


        return head.next;
    }
}