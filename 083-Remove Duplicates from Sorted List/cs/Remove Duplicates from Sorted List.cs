namespace MyLeetCode
{
    class Program
    {
        public ListNode DeleteDuplicates(ListNode head) {
            List<int> values = new List<int>();

            ListNode cur = head;
            ListNode pre = head;

            while (cur != null)
            {
                if (!values.Contains(cur.val))
                {
                    values.Add(cur.val);
                    pre = cur;
                    cur = cur.next;
                }
                else
                {
                    pre.next = cur.next;
                    cur.next = null;
                    cur = pre.next;
                }
            }

            return head;
        }   
    }
}