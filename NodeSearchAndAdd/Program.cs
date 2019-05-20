using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodeSearchAndAdd
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree thing = new BinaryTree();
            Node node = new Node(10);
            thing.Add(node, 4);
            thing.Add(node, 3);
            thing.Add(node, 8);
            thing.Add(node, 15);
            thing.Add(node, 25);
            thing.Add(node, 1);
            thing.Add(node, 90);
            thing.Search(node, 25);
            thing.Search(node, 76);
            Console.WriteLine();
        }
    }
}
