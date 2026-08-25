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
    public List<int> InorderTraversal(TreeNode root) {
        List<int> traversal = new List<int>();
        if (root == null) return traversal;

        traversal.AddRange(InorderTraversal(root.left));
        traversal.Add(root.val);
        traversal.AddRange(InorderTraversal(root.right));

        return traversal;
        
    }
}