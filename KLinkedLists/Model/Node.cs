using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLinkedLists.Model
{
    class Node
    {
        public int nodeData;
        public Node nextNode;
        public Node(int data)
        {
            nodeData = data;
            nextNode = null;
        }
    }
}
