using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Tree
{
    class BinaryTree<T> : IEnumerable<T>
        where T: IComparable<T>
    {
        public TreeNode<T> node;
        private int count;

        public void Add(T value)
        {
            if (node == null)
            {
                node = new TreeNode<T>(value);
            }
            else
            {
                AddTo(node, value);
            }
            count++;
        }

        private void AddTo(TreeNode<T> node, T value)
        {
            if (value.CompareTo(node.Value) < 0)
            {
                if (node.Left == null)
                {
                    node.Left = new TreeNode<T>(value);
                }
                else
                { 
                    AddTo(node.Left, value);
                }
            }
            else
            {
                if (node.Right == null)
                {
                    node.Right = new TreeNode<T>(value);
                }
                else
                {
                    AddTo(node.Right, value);
                }
            }
        }
        
        public bool Contains(T value)
        {
            return Find(value) != null;
        }
        
        private TreeNode<T> Find(T value)
        {
            TreeNode<T> current = node;
            
            while (current != null)
            {
                int result = current.CompareTo(value);

                if (result > 0)
                {
                    current = current.Left;
                }
                else if (result < 0)
                {
                    current = current.Right;
                }
                else
                {
                    break;
                }
            }
            return current;
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
