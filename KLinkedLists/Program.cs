// -------------------------------------------------------------------
// Darie-Dragos Mitoiu
// KLinkedLists Console App v1.0.0 12/09/2022
// A Console App designed to sort linked lists in ascending order
// -------------------------------------------------------------------

using KLinkedLists.Model;
using System;
using System.Collections;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using KLinkedLists.controller;
using KLinkedLists.util;
using KLinkedLists.Util;

namespace KLinkedLists
{
    public class Program
    {

        static Node root;
        public static void Main(String[] args)
        {
            if (args.Length < 1)
            {
                Console.WriteLine("Please provide an array of numbers, e.g: KLinkedLists.exe \"[1, 4, 5]\" \"[1, 3, 4]\" \"[2, 6]\"");
                return;
            }
            else
            {
                try
                {
                    // Number of linked lists
                    int k = args.Length;
                    Node[] array = new Node[k];
                    for (int i = 0; i < args.Length; i++)
                    {
                        string argument = args[i];
                        List<int> list = Arguments.getArgument(argument, "[", "]");
                        for (int j = 0; j < list.Count; j++)
                        {
                            int number = list[j];
                            array[i] = KLinkedListController.insertEnd(array[i], number);
                        }
                    }
                    // Merge all lists
                    root = KLinkedListController.mergeKLists(array, k - 1);
                    Logger.info(root);
                }
                catch (IOException e)
                {
                    Console.WriteLine("Opps, something went wrong, please check your arrays of numbers.");
                }
            }

        }

    }
}