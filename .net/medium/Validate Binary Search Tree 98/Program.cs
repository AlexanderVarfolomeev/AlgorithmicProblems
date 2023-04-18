/*
Given the root of a binary tree, determine if it is a valid binary search tree (BST).

A valid BST is defined as follows:

    The left
    subtree
    of a node contains only nodes with keys less than the node's key.
    The right subtree of a node contains only nodes with keys greater than the node's key.
    Both the left and right subtrees must also be binary search trees.

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

    public bool IsValidBST(TreeNode root)
    {
        if (root is null)
            return true;
        if (root.left is not null && MaxValue(root.left) > root.val)
            return false;
        if (root.right is not null && MinValue(root.right) < root.val)
            return false;

        if (!IsValidBST(root.left) || !IsValidBST(root.right))
            return false;
        return true;
    }

    int MaxValue(TreeNode node)
    {
        if (node is null)
            return Int32.MinValue;
        int value = node.val;
        int leftM = MaxValue(node.left);
        int rightM = MaxValue(node.right);

        return Math.Max(value, Math.Max(leftM, rightM));
    }
    
    int MinValue(TreeNode node)
    {
        if (node is null)
            return Int32.MaxValue;
        int value = node.val;
        int leftM = MinValue(node.left);
        int rightM = MinValue(node.right);

        return Math.Min(value, Math.Min(leftM, rightM));
    }
    
    
    public void IsValid(TreeNode root, ref bool isTrue, HashSet<int> pred)
    {
       
    }
}