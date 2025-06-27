namespace AddTwoNumbers
{
    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public class AddTwoNumbersSolver
    {
        public ListNode AddTwoNumbers_BF(ListNode l1, ListNode l2)
        {
            int num1 = 0;
            int num2 = 0;
            int multiplier = 1;

            while (l1 != null)
            {
                num1 += l1.val * multiplier;
                multiplier *= 10;
                l1 = l1.next;
            }
            multiplier = 1;

            while (l2 != null)
            {
                num2 += l2.val * multiplier;
                multiplier *= 10;
                l2 = l2.next;
            }

            int total = num1 + num2;
            ListNode dummy = new ListNode(0);
            ListNode current = dummy;
            if (total == 0) return new ListNode(0);

            while (total > 0)
            {
                int digit = total % 10;
                current.next = new ListNode(digit);
                current = current.next;
                total /= 10;
            }
            return dummy.next;
        }

        public ListNode AddTwoNumbers_Optimal(ListNode l1, ListNode l2)
        {
            ListNode dummy = new ListNode(0);
            ListNode current = dummy;
            int carry = 0;
            while (l1 != null || l2 != null || carry > 0)
            {
                int sum = carry;
                if (l1 != null)
                {
                    sum += l1.val;
                    l1 = l1.next;
                }
                if (l2 != null)
                {
                    sum += l2.val;
                    l2 = l2.next;
                }
                carry = sum / 10;
                current.next = new ListNode(sum % 10);
                current = current.next;
            }
            return dummy.next;
        }
    }
}
