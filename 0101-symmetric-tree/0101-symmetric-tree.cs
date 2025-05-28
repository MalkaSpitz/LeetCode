/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public bool IsSymmetric(TreeNode root) {
        List<int?>? l1=new();
        PreRightOrder(root,l1);
        List<int?>? l2=new();
        PreLeftOrder(root,l2);
        return l1.SequenceEqual(l2);
    }
    private void PreRightOrder(TreeNode root,List<int?>? l){
        if(root==null){
            l.Add(-1000);
            return;
        }
        l.Add(root.val);
        PreRightOrder(root.right,l);
        PreRightOrder(root.left,l);
    }
    private void PreLeftOrder(TreeNode root,List<int?>? l){
        if(root==null){
            l.Add(-1000);
            return;
        }
        l.Add(root.val);
        PreLeftOrder(root.left,l);
        PreLeftOrder(root.right,l);
    }
}