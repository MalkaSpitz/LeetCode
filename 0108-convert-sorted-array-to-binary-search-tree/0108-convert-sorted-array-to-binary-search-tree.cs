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
    public TreeNode SortedArrayToBST(int[] nums) {
        if(nums.Length==0){
            return null;
        }
        TreeNode tree=new TreeNode(nums[(nums.Length)/2], 
        SortedArrayToBST(nums.Skip(0).Take((nums.Length)/2).ToArray()),
        SortedArrayToBST(nums.Skip(((nums.Length)/2)+1).Take((nums.Length)/2).ToArray()));
        return tree;
    }
}