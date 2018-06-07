namespace MyLeetCode
{
    class Program
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode dummyNode = new ListNode(0);
            ListNode p = l1, q = l2, cur = dummyNode;
            int carry = 0;

            while (p!= null || q != null)
            {
                int x = p?.val ?? 0;
                int y = q?.val ?? 0;
                int sum = x + y + carry;
                carry = sum / 10;
                cur.next = new ListNode(sum % 10);
                cur = cur.next;

                p = p?.next;
                q = q?.next;
            }

            if(carry > 0)
                cur.next = new ListNode(carry);

            return dummyNode.next;
        }        
    }
}