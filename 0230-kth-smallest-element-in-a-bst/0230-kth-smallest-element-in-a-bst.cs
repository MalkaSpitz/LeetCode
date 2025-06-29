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
    public int counter=0;
    public int KthSmallest(TreeNode root, int k) {
        if(root==null) return -1;
        int l=KthSmallest(root.left,k);
        counter++;
        if(counter==k) return root.val;
        int r= KthSmallest(root.right,k);
        if(r==-1&&l==-1){
            return -1;
        }
        if(r!=-1) return r;
        return l;
    }
}