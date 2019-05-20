using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodeSearchAndAdd
{
    class BinaryTree
    {
        private Node start;
        public int left;
        public int right;


        public void BinaryTreeStart()
        {
            start = null;
        }

        public void CreateTree(int data)
        {

            InsertAtEnd(data);
        }

        public void InsertAtEnd(int data)
        {
            Node node;
            Node temp = new Node(data);
            if (start == null)
            {
                start = temp;
                return;
            }
            //-----------------------------------------------------------------------------------------
            node = start;
            if (temp.info <= node.info)
            {
                if (node.leftLink == null)
                {
                    node.leftLink = temp;
                }
                else { InsertAtEnd(data); }
            }
            if (node.rightLink == null)
            {
                node.rightLink = temp;
            }
            else { InsertAtEnd(data); }
        }

    }
}
}
