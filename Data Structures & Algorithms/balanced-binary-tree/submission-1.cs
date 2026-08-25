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
    public bool IsBalanced(TreeNode root) {
        if (root == null) return true;
        bool isBalanced = true;
        int left_height, right_height = 0;

        left_height = dfs(root.left);
        right_height= dfs(root.right);

        if(Math.Abs(left_height - right_height) > 1)
            isBalanced = false;


        return isBalanced && IsBalanced(root.left) && IsBalanced(root.right);
    }

    public int dfs(TreeNode root){

        int height_r = 0, height_l = 0;

        if(root == null)
            return 0;

        height_r = 1 + dfs(root.right);
        height_l = 1 + dfs(root.left);

        if(height_r >= height_l)
            return height_r;
        else
            return height_l;
    }
}
