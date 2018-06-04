namespace Solution
{
    /*
     *  给出一个链表，每 k 个节点一组进行翻转，并返回翻转后的链表。
     *  k 是一个正整数，它的值小于或等于链表的长度。如果节点总数不是 k 的整数倍，那么将最后剩余节点保持原有顺序。
     */
    class Program
    {
        public ListNode ReverseKGroup(ListNode head, int k)
        {
            ListNode dummyNode = new ListNode(0);
            dummyNode.next = head;
            ListNode cur = dummyNode;
            int i = 0;

            while (cur != null && i < k)
            {
                cur = cur.next;
                i++;
            }

            if (cur == null)
            {
                return dummyNode.next;
            }

            var right = ReverseKGroup(cur.next, k);
            var left = ReverseNode(dummyNode, cur);
            left.next = right;
            return dummyNode.next;
        }

        public ListNode ReverseNode(ListNode head,ListNode targetNode)
        {
            ListNode res = head.next;
            ListNode cur = head.next;
            ListNode rightNode = null;

            while (cur != targetNode)
            {
                ListNode nextNode = cur.next;
                cur.next = rightNode;
                rightNode = cur;
                cur = nextNode;
            }

            cur.next = rightNode;
            head.next = cur;
            return res;
        }     
    }

    class ListNode
    {
         public int val;
         public ListNode next;
         public ListNode(int x) { val = x; }
    }
}