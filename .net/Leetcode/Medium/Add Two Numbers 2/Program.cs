/*
You are given two non-empty linked lists representing two non-negative integers. 
The digits are stored in reverse order, and each of their nodes contains a single digit. Add the two numbers and return the sum as a linked list.
You may assume the two numbers do not contain any leading zero, except the number 0 itself.
*/

public class Solution
{
    public static void Main()
    {
        ListNode l = new ListNode(9,
            new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9)))))));
        ListNode s = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9))));
        AddTwoNumbers(l, s);
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

    public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        string f = "", s = "";
        ListNode list1 = l1;
        ListNode list2 = l2;

        Queue<int> q1 = new Queue<int>();
        Queue<int> q2 = new Queue<int>();

        while (list1 != null)
        {
            q1.Enqueue(list1.val);
            list1 = list1.next;
        }

        while (list2 != null)
        {
            q2.Enqueue(list2.val);
            list2 = list2.next;
        }

        l1 = new ListNode();
        l2 = l1;
        int ost = 0;
        while (q1.Count != 0 || q2.Count != 0)
        {
            int sum = 0;
            if (q1.Count == 0)
            {
                sum = q2.Dequeue() + ost;
            }
            else if (q2.Count == 0)
            {
                sum = q1.Dequeue() + ost;
            }
            else
            {
                sum = q1.Dequeue() + q2.Dequeue() + ost;
            }

           

            if (sum > 9)
            {
                ost = 1;
                l2.val = sum % 10;
            }
            else
            {
                ost = 0;
                l2.val = sum;
            }
            if (q1.Count == 0 && q2.Count == 0)
            {
                if (ost != 0)
                    l2.next = new ListNode(ost);
                break;
            }
            l2.next = new ListNode();
            l2 = l2.next;
        }

        return l1;
    }
}