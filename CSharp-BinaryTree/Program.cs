using System;

namespace CSharp_BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree binaryTree = new BinaryTree();

            binaryTree.Insert(75);
            binaryTree.Insert(65);
            binaryTree.Insert(45);
            binaryTree.Insert(35);
            binaryTree.Insert(135);
          
            var node = binaryTree.Find(45);
            Console.WriteLine(node.Data);
        }
    }
}
