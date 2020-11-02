using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_BinaryTree
{
    class BSTNode
    {
        public BSTNode leftNode { get; set; }
        public BSTNode rightNode { get; set; }
        public int Data { get; set; }

        public BSTNode(int value)
        {
            Data = value;
        }

        public void Insert(int value)
        {
            if (value >= Data)
            {
                if (rightNode == null)
                {
                    rightNode = new BSTNode(value);
                }
                else
                {
                    rightNode.Insert(value);
                }
            }
            else
            {
                if (leftNode == null)
                {
                    leftNode = new BSTNode(value);
                }
                else
                {
                    leftNode.Insert(value);
                }
            }
        }

        public void inOrderTraversal()
        {
            if (leftNode != null)
            {
                leftNode.inOrderTraversal();
            }
            Console.Write(Data + " ");

            if (rightNode != null)
            {
                rightNode.inOrderTraversal();
            }
        }

        public void preOrderTraversal()
        {

            if (rightNode != null)
            {
                rightNode.preOrderTraversal();
            }
            Console.Write(Data + " ");
            if (leftNode != null)
            {
                leftNode.preOrderTraversal();
            }
        }

        public void postOrderTraversal()
        {
            if (leftNode != null)
            {
                leftNode.postOrderTraversal();
            }
            if (rightNode != null)
            {
                rightNode.postOrderTraversal();
            }
            Console.Write(Data + " ");

        }

        public BSTNode Find(int value)
        {
            BSTNode currentNode = this;

            while(currentNode != null)
            {
                if (value == currentNode.Data)
                {
                    return currentNode;
                }
                else if (value > currentNode.Data)
                {
                    currentNode = currentNode.rightNode;
                }
                else
                {
                    currentNode = currentNode.leftNode;
                }
            }
            return null;
        }
    }
}
