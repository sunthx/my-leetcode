namespace Solution
{
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