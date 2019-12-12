using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree binaryTree = new BinaryTree();
            binaryTree.Add(100);
            binaryTree.Add(40);
            binaryTree.Add(70);
            binaryTree.Add(160);
            binaryTree.Add(10);
            binaryTree.Add(140);

            bool result = binaryTree.Find(100);

        }
    }
}
