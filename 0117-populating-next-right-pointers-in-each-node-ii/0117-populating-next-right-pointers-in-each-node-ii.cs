/*
// Definition for a Node.
public class Node {
    public int val;
    public Node left;
    public Node right;
    public Node next;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, Node _left, Node _right, Node _next) {
        val = _val;
        left = _left;
        right = _right;
        next = _next;
    }
}
*/

public class Solution {
    public Node Connect(Node root) {
        #nullable enable
        Queue<Node?> q=new ();
        #nullable disable
        q.Enqueue(root);
        q.Enqueue(null);
        Node last=null;
        if(root==null||(root.left==null&&root.right==null)) return root;
        Node temp;
        while(q.Count>1){
            temp=q.Dequeue();
            if(temp==null){
                q.Enqueue(null);
                last=null;
            }
            else{
                temp.next=last;
                last=temp;
                if(temp.right!=null){
                    q.Enqueue(temp.right);
                }
                if(temp.left!=null){
                    q.Enqueue(temp.left);
                }
            }
            
        }
        return root;
    }
}