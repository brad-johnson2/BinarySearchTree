using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class Node
    {
        public int number;
        public Node leftChild;
        public Node rightChild;


        public Node(int value)
        {
            number = value;
            rightChild = null;
            leftChild = null;
        }


        public void Add(Node node, int data)
        {
            if (node == null)
            {
                node = new Node(data);

            }
            else if (node.number < data)
            {
                Add(node.rightChild, data);
            }

            else if (node.number > data)
            {
                Add(node.leftChild, data);
            }
        }

        public Node Search(Node node, int searchQuery)
        {
            if (node.number == searchQuery)
            {
                return node;
            }
            else if (node.number < searchQuery)
            {
                return Search(node.rightChild, searchQuery);
            }
            else if (node.number > searchQuery)
            {
                return Search(node.leftChild, searchQuery);
            }
            return null;
            
        }
    }

}
