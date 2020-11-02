using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Transactions;

namespace CSharp_BinaryTree
{
    class BinaryTree
    {
        public BSTNode root { get; set; }

        public void Insert(int data)
        {
            if (root != null)
            {
                root.Insert(data);
            }
            else
            {
                root = new BSTNode(data);
            }
        }

        public void inOrderTraversal()
        {
            if (root != null)
            {
                root.inOrderTraversal();
            }
        }
        public void preOrderTraversal()
        {
            if (root != null)
            {
                root.preOrderTraversal();
            }
        }

        public void postOrderTraversal()
        {
            if (root != null)
            {
                root.postOrderTraversal();
            }
        }

        public BSTNode Find(int data)
        {
            if (root != null)
            {
                return root.Find(data);
            }
            else
            {
                return null;
            }
        }
    }
}
