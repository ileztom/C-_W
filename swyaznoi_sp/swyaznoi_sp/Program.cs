namespace swyaznoi_sp
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

    public class Solution
    {
        public ListNode FindMiddleNode(ListNode head)
        {
            if (head == null) return null;

            ListNode slow = head;
            ListNode fast = head;

            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }
            return slow;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ListNode node5 = new ListNode(5);
            ListNode node4 = new ListNode(4, node5);
            ListNode node3 = new ListNode(3, node4);
            ListNode node2 = new ListNode(2, node3);
            ListNode node1 = new ListNode(1, node2);

            Solution solution = new Solution();
            ListNode middleNode = solution.FindMiddleNode(node1);
            Console.WriteLine("Середина связного списка " + middleNode.val);
        }
    }
}
