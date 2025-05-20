/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
        public ListNode SwapPairs(ListNode head) {
        ListNode dummy = new ListNode(0, head);
        ListNode temp = dummy;

        while (temp.next != null && temp.next.next != null) {
            ListNode first = temp.next;
            ListNode second = temp.next.next;

            // החלפה
            first.next = second.next;
            second.next = first;
            temp.next = second;

            // קפיצה לזוג הבא
            temp = first;
        }

        return dummy.next;
    }
}