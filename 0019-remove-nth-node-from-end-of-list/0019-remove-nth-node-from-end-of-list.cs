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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        ListNode p=head;
        int count=0;
        while(p!=null){
            count++;
            p=p.next;
        }        
        int toRemove=count-n-1;
        p=head;
        int ind=0;
        while(ind<toRemove){
            ind++;
            p=p.next;
        }
        if(toRemove==-1) return head.next;
        p.next=p.next.next;
        return head;
    }
}