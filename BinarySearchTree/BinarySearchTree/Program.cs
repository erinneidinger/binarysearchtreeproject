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
            binaryTree.Add(5);
            binaryTree.Add(4);
            binaryTree.Add(7);
            binaryTree.Add(6);
            binaryTree.Add(1);
            binaryTree.Add(15);

            binaryTree.Find(7);

        }
    }
}
