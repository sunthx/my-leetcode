namespace Solution
{
    class Program
    {
        public ListNode SwapPairs(ListNode head)
        {
            ListNode dummyNode = new ListNode(0);
            dummyNode.next = head;
            ListNode cur = dummyNode;

            ListNode firstNode = cur.next;
            ListNode secondNode = cur.next?.next;

            while (firstNode != null && secondNode != null)
            {
                ListNode next = secondNode.next;
                secondNode.next = firstNode;
                firstNode.next = next;
                cur.next = secondNode;

                cur = firstNode;
                secondNode = cur.next?.next;
                firstNode = cur.next;
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