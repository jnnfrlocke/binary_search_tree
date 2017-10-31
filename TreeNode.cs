using System;
using System.Collections;
using System.Collections.Generic;


namespace Binary_Search_Tree
{
    class TreeNode<TNode> : IComparable<TNode>
        where TNode : IComparable<TNode>
    {
        public TreeNode(TNode value)
        {
            Value = value;
        }

        public TreeNode<TNode> Left { get; set; }
        public TreeNode<TNode> Right { get; set; }
        public TNode Value { get; private set; }
        
        public int CompareTo(TNode other)
        {
            return Value.CompareTo(other);
        }
    }
}
