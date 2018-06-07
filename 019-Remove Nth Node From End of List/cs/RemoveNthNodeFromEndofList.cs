namespace Solution
{
    class MyLeetCode
    {
        public ListNode RemoveNthFromEnd2(ListNode head, int n)
        {
            ListNode dummyNode = new ListNode(0);
            dummyNode.next = head;

            ListNode cur = dummyNode;

            int lenght = 0;
            while (cur.next != null)
            {
                lenght++;
                cur = cur.next;
            }

            cur = dummyNode;
            for (int i = 0; i < lenght - n; i++)
            {
                cur = cur.next;
            }

            cur.next = cur.next.next;

            return dummyNode.next;
        }        
    }
}