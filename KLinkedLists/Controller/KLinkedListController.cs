using KLinkedLists.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLinkedLists.controller
{
    class KLinkedListController
    {
        public static Node mergeKLists(Node[] arr, int last)
        {

            // Traverse form second list to last
            for (int i = 1; i <= last; i++)
            {
                while (true)
                {

                    // head of both the lists,
                    // 0 and ith list. 
                    Node head_0 = arr[0];
                    Node head_i = arr[i];

                    // Break if list ended
                    if (head_i == null)
                        break;

                    // Smaller than first element
                    if (head_0.nodeData >= head_i.nodeData)
                    {
                        arr[i] = head_i.nextNode;
                        head_i.nextNode = head_0;
                        arr[0] = head_i;
                    }
                    else
                    {

                        // Traverse the first list
                        while (head_0.nextNode != null)
                        {

                            // Smaller than next element
                            if (head_0.nextNode.nodeData >= head_i.nodeData)
                            {
                                arr[i] = head_i.nextNode;
                                head_i.nextNode = head_0.nextNode;
                                head_0.nextNode = head_i;
                                break;
                            }

                            // go to next node
                            head_0 = head_0.nextNode;

                            // if last node
                            if (head_0.nextNode == null)
                            {
                                arr[i] = head_i.nextNode;
                                head_i.nextNode = null;
                                head_0.nextNode = head_i;
                                head_0.nextNode.nextNode = null;
                                break;
                            }
                        }
                    }
                }
            }
            return arr[0];
        }
        public static Node insertEnd(Node node, int data)
        {
            // If linked list is empty, create a
            // new node (Assuming newNode() allocates
            // a new node with given data)
            if (node == null)
                return new Node(data);

            // If we have not reached end, keep traversing
            // recursively.
            else
                node.nextNode = insertEnd(node.nextNode, data);
            return node;
        }
    }
}
