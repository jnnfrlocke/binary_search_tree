using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Tree
{
    public class BinarySearchTree
    {
        private Node root;

        public BinarySearchTree()
        {
            root = null;
        }

        public void NewTree()
        {
            root = new Node(15);
            root.leftNode = new Node(7);
            root.rightNode = new Node(20);
            root.leftNode.leftNode = new Node(3);
            root.leftNode.leftNode = new Node(10);
            root.rightNode.leftNode = new Node(17);
            root.rightNode.rightNode = new Node(26);
        }

    }
}
