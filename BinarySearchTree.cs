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
            root.leftNode.rightNode = new Node(10);
            root.rightNode.leftNode = new Node(17);
            root.rightNode.rightNode = new Node(26);
        }

        public void InitiateSearch()
        {
            Console.WriteLine("What number are you searching for?");
            int input = Convert.ToInt16(Console.ReadLine());
            Search(input);
        }



        public void Search(int input)
        {
            int result;
            int topRoot = root.value;
            int lOneLeft = root.leftNode.value;
            int lOneRight = root.rightNode.value;
            int lTwoLeft = root.leftNode.leftNode.value;
            int lTwoLR = root.leftNode.rightNode.value;
            int lTwoRL = root.rightNode.leftNode.value;
            int lTwoRight = root.rightNode.rightNode.value;

            if (input == topRoot)
            {
                result = topRoot;
                Console.WriteLine("Your number is in the Binary Search Tree.");
                Console.ReadLine();
            }

            else if (input < topRoot)
            {
                if (input == lOneLeft)
                {
                    result = lOneLeft;
                    Console.WriteLine("Your number is in the Binary Search Tree.");
                    Console.ReadLine();
                }
                else if (input < lOneLeft)
                {
                    if (input == lTwoLeft)
                    {
                        result = lTwoLeft;
                        Console.WriteLine("Your number is in the Binary Search Tree.");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Your number is not found.");
                        Console.ReadLine();
                    }
                }
                else if (input > lOneLeft && input < topRoot)
                {
                    if (input == lTwoLR)
                    {
                        result = lTwoLR;
                        Console.WriteLine("Your number is in the Binary Search Tree.");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Your number is not found.");
                        Console.ReadLine();
                    }
                }
                else if (input > lOneRight && input < topRoot)
                {
                    if (input == lTwoLR)
                    {
                        result = lTwoLR;
                        Console.WriteLine("Your number is in the Binary Search Tree.");
                        Console.ReadLine();
                    }
                    {
                        Console.WriteLine("Your number is not found.");
                        Console.ReadLine();
                    }
                }
            }
            else if (input > topRoot)
            {
                if (input == lOneRight)
                {
                    result = lOneRight;
                    Console.WriteLine("Your number is in the Binary Search Tree.");
                    Console.ReadLine();
                }
                else if (input < lOneRight)
                {
                    if (input == lTwoRL)
                    {
                        result = lTwoRL;
                        Console.WriteLine("Your number is in the Binary Search Tree.");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Your number is not found.");
                        Console.ReadLine();
                    }
                }
                else if (input > lOneRight)
                {
                    if (input == lTwoRight)
                    {
                        result = lTwoRight;
                        Console.WriteLine("Your number is in the Binary Search Tree.");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Your number is not found.");
                        Console.ReadLine();
                    }
                }



            }
        }
    }
}
