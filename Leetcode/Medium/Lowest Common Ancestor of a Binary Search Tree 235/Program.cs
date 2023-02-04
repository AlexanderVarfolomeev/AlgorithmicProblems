/*
Given a binary search tree (BST), find the lowest common ancestor (LCA) node of two given nodes in the BST.

According to the definition of LCA on Wikipedia: 
“The lowest common ancestor is defined between two nodes p and q as the lowest node in T 
that has both p and q as descendants (where we allow a node to be a descendant of itself).”
*/

public class Solution
{
    public static void Main()
    {
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    public HashSet<TreeNode> set = new HashSet<TreeNode>();

    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
    {
        TreeNode res = new TreeNode();
        PathToNum(root, p, res); 
        PathToNum(root, q, res);
        return res;
    }

    public void PathToNum(TreeNode root, TreeNode node, TreeNode res)
    {
        if (set.Contains(root))
        {
            res = root;
            return;
        }

        if (root == node)
            return;
        PathToNum(node.val > root.val ? root.right : root.left, node, res);
    }
}