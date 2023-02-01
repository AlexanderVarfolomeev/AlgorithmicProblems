/*
Given the root of a binary tree, return the level order traversal of its nodes' values. (i.e., from left to right, level by level).
*/

using System.Collections.ObjectModel;

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

    public Dictionary<int, List<int>> result = new Dictionary<int, List<int>>();

    public void Obh(TreeNode node, int level)
    {
        if(node is null)
            return;
        
        if(!result.ContainsKey(level))
            result.Add(level, new List<int>());
        result[level].Add(node.val);
        Obh(node.left, level + 1);
        Obh(node.right, level + 1);
    }

    public IList<IList<int>> LevelOrder(TreeNode root)
    {
        Obh(root, 1);
        IList<IList<int>> list = new List<IList<int>>();
        int i = 0;
        foreach (var set in result)
        {
            list.Add(new List<int>());
            foreach (var val in set.Value)
            {
                list[i].Add(val);
            }

            i++;
        }

        return list;
    }
}