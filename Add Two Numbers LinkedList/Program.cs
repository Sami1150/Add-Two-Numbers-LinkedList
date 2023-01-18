/**
 * Definition for singly-linked list.
 * Add two numbers of a single linked list 
 * Handle carry cases as well
 */
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

public class Solution
{
    public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        int carry = 0;
        int sum = 0;
        ListNode dummy = new ListNode(0);
        ListNode pre = dummy;
        while (l1 != null || l2 != null || carry == 1)
        {
            sum = (l1 == null ? 0 : l1.val) + (l2 == null ? 0 : l2.val) + carry;
            carry = sum < 10 ? 0 : 1;

            pre.next = new ListNode(sum % 10);
            pre = pre.next;
            if (l1 != null)
            {
                l1 = l1.next;
            }

            if (l2 != null)
            {
                l2 = l2.next;
            }
        }
        return dummy.next;
    }
}