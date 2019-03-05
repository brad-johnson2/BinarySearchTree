using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class Node
    {
        public int Data;
        public Node LeftChild;
        public Node RightChild;
    }

    public class BinarySearchTree
    {
        public Node root;
        public BinarySearchTree()
        {
            root = null;
        }
    }

    public void AddNode(int data)
    {
        Node newNode = new Node();
        if (root == null)
        {
            root = newNode;
        }
        else
        {
            Node current = root;
        }
    }

    

    

    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree newTree = new BinarySearchTree();
            newTree.Add(25);
        }
            
    }

    


}
