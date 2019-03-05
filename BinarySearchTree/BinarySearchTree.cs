using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinarySearchTree
    {
        private Node root;

        public int Count { get; private set; }

      
        public void BinaryTree()
        {
            root = null;
            Count = 0;
        }

        public void Add(int dataNumber)
        {
            if (root == null)
            {
                root = new Node(dataNumber);
            }
            else
            {
                Add(dataNumber);
            }

            Count++;
        }

        public int Search(int searchQuery)
        {
            return Search(searchQuery);
        }






    }
}
