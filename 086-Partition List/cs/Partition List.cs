namespace MyLeetCode
{
    class Program
    {
        public ListNode Partition(ListNode head, int x)
        {
            if (head == null)
                return null;

            ListNode dummyNode = new ListNode(0);
            dummyNode.next = head;

            ListNode cur = dummyNode;
            ListNode pre = dummyNode;
            ListNode bigger = null;

            while (cur.next != null)
            {
                if (bigger == null && cur.next.val >= x)
                {
                    pre = cur;
                    bigger = cur.next;
                }

                if (cur.next.val < x && bigger != null)
                {
                    ListNode nextNode = cur.next.next;

                    pre.next = cur.next;
                    pre.next.next = bigger;
                    pre = pre.next;

                    cur.next = nextNode;
                }
                else
                {
                    cur = cur.next;
                }
            }

            return dummyNode.next;

        }     
    }
}