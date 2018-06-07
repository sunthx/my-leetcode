namespace MyLeetCode
{
    class Program
    {
        public ListNode RotateRight(ListNode head, int k)
        {
            if (head == null)
                return null;

            int length = 1;
            ListNode end = head;
            while (end.next != null)
            {
                length++;
                end = end.next;
            }

            if (length == 0 || length == 1)
                return head;

            k = k % length;
            if (k == 0)
                return head;

            int index = length - k;
            ListNode currentNode = head, pre = null;
            for (int i = 0; i < index; i++)
            {
                pre = currentNode;
                currentNode = currentNode.next;
            }

            end.next = head;
            pre.next = null;
                           
            return currentNode;  
        }        
    }
}