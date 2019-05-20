using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodeSearchAndAdd
{
    class BinaryTree
    {

        public void Add(Node node, int data)
        {
            Node temporary = new Node(data);

            if (temporary.info <= node.info)
            {
                if (node.leftLink == null)
                {
                    node.leftLink = temporary;
                }
                else
                {
                    Add(node.leftLink, data);
                }

            }
            if (temporary.info > node.info)
                if (node.rightLink == null)
                {
                    node.rightLink = temporary;
                }
                else { Add(node.rightLink, data); }

        }
        public void Search(Node node, int data)
        {
            if (data == node.info)
            {
                Console.Write(node.info);
            }
            if (data <= node.info)
            {
                if (node.leftLink == null)
                {
                    Console.WriteLine("No data found");
                }
                else if (data == node.leftLink.info)
                {
                    Console.Write(node.leftLink.info);
                }
                else
                {
                    Search(node.leftLink, data);
                }

            }
            if (data > node.info)
            {
                if (node.rightLink == null)
                {
                    Console.WriteLine("No data found");
                }
                else if (data == node.rightLink.info)
                {
                    Console.Write(node.rightLink.info);
                }
                else
                {
                    Search(node.rightLink, data);
                }

            }
        }
    }
}

