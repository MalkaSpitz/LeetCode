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
    public int SumNumbers(TreeNode root) {
        return SumNumbers(root, 0,0);
    }
    public int SumNumbers(TreeNode root,int num,int sum) {
        if(root.right==null&&root.left==null){
            return sum+num*10+root.val;
        }
        int r=0;
        int l=0;
        if(root.left!=null){
            l= SumNumbers(root.left, num*10+root.val,sum);
        }
        if(root.right!=null){
            r= SumNumbers(root.right, num*10+root.val,sum);
        }
        return l+r;
    }
}