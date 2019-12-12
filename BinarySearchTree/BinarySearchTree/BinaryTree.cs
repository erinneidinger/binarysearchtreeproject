using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinaryTree
    {
        public Node root;

        public BinaryTree()
        {
            root = null;
        }

        public void Add(int data)
        {
            Node node = new Node(data);
            if (root == null)
            {
                root = node;
                return;
            }
            else {
                Node temp = root;
                Node parent;
                while (true)
                {
                    parent = temp;

                    if (data < temp.data)
                    {
                        temp = temp.LeftChild;
                        if (temp == null)
                        {
                            parent.LeftChild = node;
                            break;
                        }
                    }
                    else
                    {
                        temp = temp.RightChild;
                        if(temp == null)
                        {
                            parent.RightChild = node;
                            break;
                        }
                    }
                }
            }
        }


        public bool Find(int data)
        {
            if (data == root.data)
            {
                return true;
            }
            Node currentroot = root;
            while (currentroot.data != data)
            {
                if (data < currentroot.data && currentroot.LeftChild != null)
                {
                    currentroot = currentroot.LeftChild;
                }
                else if (data > currentroot.data && currentroot.RightChild != null)
                {
                    currentroot = currentroot.RightChild;
                }
                else
                {
                    return false;
                }
            }
            if (currentroot.data == data)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
    }
}
