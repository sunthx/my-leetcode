namespace MyLeetCode
{
    class Program
    {
        public ListNode AddTwoNumbers2(ListNode l1, ListNode l2)
        {
            ListNode dummyNode = new ListNode(0);
            ListNode p = l1, q = l2, cur = dummyNode;
            int carry = 0;

            Stack<int> stack1 = new Stack<int>();
            Stack<int> stack2 = new Stack<int>();
            Stack<int> total = new Stack<int>();

            while (l1 != null)
            {
                stack1.Push(l1.val);
                l1 = l1.next;
            }

            while (l2 != null)
            {
                stack2.Push(l2.val);
                l2 = l2.next;
            }

            while (stack1.Count > 0 || stack2.Count > 0)
            {
                int x = stack1.Count > 0 ? stack1.Pop() : 0;
                int y = stack2.Count > 0 ? stack2.Pop() : 0;

                int sum = x + y + carry;
                carry = sum / 10;

                total.Push(sum);
            }

            if (carry != 0)
                total.Push(carry);

            while (total.Count > 0)
            {
                cur.next = new ListNode(total.Pop());
                cur = cur.next;
            }

            return dummyNode.next;
        }        
    }
}