/*
Given the root of a binary tree, return the preorder traversal of its nodes' values.
Follow up: Recursive solution is trivial, could you do it iteratively?
*/

using System.Collections.ObjectModel;

public class Solution
{
    public static void Main()
    {
        PreorderTraversal(new TreeNode(3, new TreeNode(4), new TreeNode(6)));
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

    public static IList<int> PreorderTraversal(TreeNode root)
    {
        if (root is null)
            return new List<int>();
            List<int> list = new List<int>();

            TreeNode node = root;
            Stack<TreeNode> stack = new Stack<TreeNode>();
            stack.Push(node);
            while (stack.Count != 0)
            {
                node = stack.Pop();
                list.Add(node.val);
                if(node.right is not null)
                    stack.Push(node.right);
                if(node.left is not null)
                    stack.Push(node.left);
            }
            return list;
    }

}