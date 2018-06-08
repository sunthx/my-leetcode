namespace MyLeetCode
{
    class Program
    {
        public ListNode OddEvenList(ListNode head)
        {
            if (head?.next == null)
            {
                return head;
            }

            ListNode firstOdd = head;
            ListNode firstEven = head.next;
            ListNode pre = head.next;
            ListNode cur = head.next.next;

            int count = 1;
            while (cur != null)
            {
                if (count % 2 != 0)
                {
                    ListNode next = cur.next;
                    firstOdd.next = cur;
                    cur.next = firstEven;
                    pre.next = next;

                    firstOdd = firstOdd.next;
                    cur = next;
                }
                else
                {
                    pre = cur;
                    cur = cur.next;
                }

                
                count++;
            }

            return head;
        }        
    }
}