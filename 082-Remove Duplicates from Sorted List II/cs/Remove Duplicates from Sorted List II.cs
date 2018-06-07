namespace MyLeetCode
{
    class Program
    {
        public ListNode DeleteDuplicates(ListNode head) {
            if (head == null)
                return null;

            ListNode dummyNode = new ListNode(0);

            ListNode pre = dummyNode;
            ListNode cur = head;
            ListNode next = cur.next;
            int duplicateCount = 0;

            while (next != null)
            {
                if (next.val == cur.val)
                {
                    duplicateCount++;
                }
                else
                {
                    if (duplicateCount == 0)
                    {
                        pre.next = cur;
                        pre = cur;
                        cur = next;
                    }
                    else
                    {
                        duplicateCount = 0;
                        cur = next;
                    }
                }

                next = next.next;     
            }

            if (duplicateCount == 0)
            {
                pre.next = cur;
            }
            else
            {
                pre.next = null;
            }


            return dummyNode.next;
        }   
    }
}