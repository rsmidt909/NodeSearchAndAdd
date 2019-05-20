using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodeSearchAndAdd
{
    class Node
    {
        public int info;
        public Node rightLink;
        public Node leftLink;
        public Node(int info)
        {
            this.info = info;
            rightLink = null;
            leftLink = null;            
        }
    }
}
