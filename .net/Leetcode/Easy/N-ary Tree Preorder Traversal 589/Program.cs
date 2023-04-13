/*
 * Given the root of an n-ary tree, return the preorder traversal of its nodes' values.

   Nary-Tree input serialization is represented in their level order traversal. Each group of children is separated by the null value (See examples)
*/

using System.Collections.ObjectModel;

public class Solution
{
    public static void Main()
    {
    }

    public class Node
    {
        public int val;
        public IList<Node> children;

        public Node()
        {
        }

        public Node(int _val)
        {
            val = _val;
        }

        public Node(int _val, IList<Node> _children)
        {
            val = _val;
            children = _children;
        }
    }

    public List<int> result = new List<int>();

    public void Obh(Node node)
    {
        result.Add(node.val);

        foreach (var child in node.children)
        {
            Obh(child);
        }
    }
        
    public IList<int> Preorder(Node root)
    {
        if (root is null)
            return new List<int>();
        Obh(root);
        return result;
    }
}