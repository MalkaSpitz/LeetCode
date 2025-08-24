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
    public ListNode RotateRight(ListNode head, int k) {
        if(k==0||head==null) return head;
        ListNode temp=head;
        int count=0;
        while(temp!=null){
            count++;
            temp=temp.next;
        }
        k=k%count;
        if(k==0) return head;
        temp=head;
        int ind=0;
        while(ind<count-k-1){
            ind++;
            temp=temp.next;
        }
        ListNode first=temp.next;
        temp.next=null;
        ListNode temp2=first;
        while(temp2.next!=null){
            temp2=temp2.next;
        }
        temp2.next=head;
        return first;
    }
}