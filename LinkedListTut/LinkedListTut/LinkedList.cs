using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FedsLinkedList
{
    internal class LinkedList
    {
        // Class variables
        private Print print = new Print();
        private Node headNode;

        // Constructor
        public LinkedList()
        {
            headNode = null;
        }

        // This method prints node to console
        public void printConsole()
        {
            if (headNode != null)
            {
                headNode.printConsole();
            }

        }

        // This method adds a node to the end of the list
        public void addToEnd(object data)
        {
            if (headNode == null)
            {
                headNode = new Node(data);
            }
            else
            {
                headNode.addToEndofList(data);
            }
        }

        // This method adds a node to the beginning of the list
        public void addToBeginning(object data)
        {
            if(headNode == null)
            {
                headNode = new Node(data);
            }
            else 
            {
                Node temp = new Node(data);
                temp.next = headNode;
                headNode = temp;
            }
        }

    }
}
