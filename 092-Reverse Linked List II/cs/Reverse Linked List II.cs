/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode ReverseBetween(ListNode head, int m, int n) {
            if(head == null)
                return null;

            if (m == n)
                return head;

            ListNode dummyNode = new ListNode(0);
            dummyNode.next = head;

            ListNode pre = dummyNode;
            ListNode cur = dummyNode.next;


            for (int i = 0; i < n - 1; i++)
            {
                if(cur == null || cur.next == null)
                    break;

                if (m - 1 > 0)
                {
                    pre = cur;
                }

                if (m != 0)
                {
                    m--;
                }

                if (m == 0)
                {
                    ListNode next = cur.next;
                    ListNode first = pre.next;

                    cur.next = cur.next?.next;
                    pre.next = next;
                    next.next = first;
                }
                else
                {
                    cur = cur.next;
                }
              
            }

            return dummyNode.next;
    }
}