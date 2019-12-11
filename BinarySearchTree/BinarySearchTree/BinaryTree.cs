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


        public int Find(int data)
        {
            if (data < root.data)
            {
                while (true)
                {
                    if (data == root.LeftChild.data)
                    {
                        return data;
                    }
                    else if (data < root.LeftChild.data)
                    {

                    }
                    else
                    {

                    }
                }
            }
            else
            {
                while (true)
                {
                    if (data == root.RightChild.data)
                    {
                        return data;
                    }
                    else if (data < root.RightChild.data)
                    {

                    }
                    else
                    {

                    }
                }
            }
        }
    }
}
