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
    public List<int> RightSideView(TreeNode root) {
        Queue<TreeNode> queue = new Queue<TreeNode>();
        List<List<int>> levels = new List<List<int>>();
        int level = 0;
        if (root != null)
            queue.Enqueue(root);

        while(queue.Count > 0)
        {
            List<int> level_nodes = new List<int>();
            int length = queue.Count;
            for(int i = 0; i < length; i++)
            {
                TreeNode curr = queue.Dequeue();
                level_nodes.Add(curr.val);

                if(curr.left != null)
                    queue.Enqueue(curr.left);
                if(curr.right != null)
                    queue.Enqueue(curr.right);
            }
            level++;
            levels.Add(level_nodes);
        }

        List<int> final_list = new List<int>();

        foreach(List<int> l in levels)
        {
            final_list.Add(l[l.Count-1]);
        }

        return final_list;

    }
}
