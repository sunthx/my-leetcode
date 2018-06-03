namespace Solution
{
    class Program
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            ListNode dummyNode = new ListNode(0);
            ListNode cur = dummyNode;
            ListNode p1 = l1;
            ListNode p2 = l2;

            while (p1 != null && p2 != null)
            {
                if (p1.val < p2.val)
                {
                    cur.next = p1;
                    p1 = p1.next;
                }
                else
                {
                    cur.next = p2;
                    p2 = p2.next;
                }

                cur = cur.next;
            }

            if (p1 != null)
            {
                cur.next = p1;
            }
            else
            {
                cur.next = p2;
            }

            return dummyNode.next;

        }    
    }

    class ListNode
    {
         public int val;
         public ListNode next;
         public ListNode(int x) { val = x; }
    }
}