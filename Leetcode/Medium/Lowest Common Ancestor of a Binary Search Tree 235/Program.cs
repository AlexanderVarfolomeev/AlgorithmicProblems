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
        TreeNode n2 = new TreeNode(1);
        TreeNode n1 = new TreeNode(2, n2);
        LowestCommonAncestor(n1, n1, n2);
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
    
    public static TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
    {
        Stack<TreeNode> s1 = new Stack<TreeNode>();
        Stack<TreeNode> s2 = new Stack<TreeNode>();
        PathToNum(root, p, s1);
        PathToNum(root, q, s2);
        HashSet<TreeNode> set = new HashSet<TreeNode>();
        while (s1.Count != 0)
            set.Add(s1.Pop());
        while (s2.Count!=0)
        {
            TreeNode n = s2.Pop();
            if (set.Contains(n))
                return n;
        }

        return new TreeNode();
    }

    public static void PathToNum(TreeNode root, TreeNode node, Stack<TreeNode> stack)
    {
        stack.Push(root);

        if(root == node)
            return;
        PathToNum(node.val > root.val ? root.right : root.left, node, stack);
    }
    
}