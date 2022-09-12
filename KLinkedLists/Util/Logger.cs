using KLinkedLists.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLinkedLists.util
{
    class Logger
    {
        public static void info(Node node)
        {
            while (node != null)
            {
                Console.Write(node.nodeData + " ");
                node = node.nextNode;
            }
            Console.WriteLine();
        }
    }
}
