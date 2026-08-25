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
    public List<List<int>> LevelOrder(TreeNode root) {

        Queue<TreeNode> queue = new Queue<TreeNode>();
        List<List<int>> final_list = new List<List<int>>();

        if (root == null)
            return [];

        if(root != null)
            queue.Enqueue(root);

        int level = 0;

        while(queue.Count > 0)
        {
            Console.WriteLine("Current_queue" + string.Join(" ", queue));
            Console.WriteLine("Level: " + level);
            int length = queue.Count;
            List<int> aux_list = new List<int>();
            for(int i = 0; i < length; i++){
                TreeNode curr = queue.Dequeue();
                if (curr.left != null)
                    queue.Enqueue(curr.left);
                if(curr.right != null)
                    queue.Enqueue(curr.right);

                aux_list.Add(curr.val);
            }
            final_list.Add(aux_list);
            level++;
        }

        return final_list;

    }
}
