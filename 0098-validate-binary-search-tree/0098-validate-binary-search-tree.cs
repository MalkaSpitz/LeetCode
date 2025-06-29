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
    TreeNode last=null;
    bool valid=true;
    public bool IsValidBST(TreeNode root) {
        DFS(root);
        return valid;
    }
    public void DFS(TreeNode root) {
        if(root==null) return;
        DFS(root.left);
        if(last==null) last=root;
        else if(root.val<=last.val) valid=false;
        last=root;
        DFS(root.right);
    }
}