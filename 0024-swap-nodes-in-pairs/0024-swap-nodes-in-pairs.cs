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
        ListNode dummy=new(0,head);
        ListNode p=dummy;
        while(p.next!=null&&p.next.next!=null){
            Console.WriteLine($"{p.next.val} {p.next.next.val} ");
            ListNode temp=p.next;
            ListNode nextP=p.next.next.next;
            p.next=p.next.next;
            p.next.next=temp;
            temp.next=nextP;
            p = p.next.next;
        
        }
        return dummy.next;
    }
}