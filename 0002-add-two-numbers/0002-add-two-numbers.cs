public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode res2=new();
        ListNode res=res2;
        int s=0;
        while(l1!=null&&l2!=null){
            int sum=l1.val+l2.val+s;
            s=sum/10;
            res.next=new ListNode(sum%10);
            res=res.next;
            l1=l1.next;
            l2=l2.next;
        }
        while(l1!=null){
            int sum=l1.val+s;
            s=sum/10;
            res.next=new ListNode(sum%10);
            res=res.next;
            l1=l1.next;
        }
        while(l2!=null){
            int sum=l2.val+s;
            s=sum/10;
            res.next=new ListNode(sum%10);
            res=res.next;
            l2=l2.next;
        }
        if(s>0){
             res.next=new ListNode(s);
        }
        return res2.next;
    }
}
