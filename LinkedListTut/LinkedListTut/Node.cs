using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FedsLinkedList
{
    internal class Node
    {
        // Class variables
        private Print print = new Print();
        public object data;
        public Node next;

        // Constructor
        public Node(object data) 
        {
            this.data = data;
            next = null;
        }

        // This method prints messages to the console
        public void printConsole()
        {
            print.log("(" + data + ")-> ");
            // If next is not null, recursively keep printing values until list is done
            if (next != null)
            {
                next.printConsole();
            }
        }

        // This method adds a node to the end of the list
        public void addToEndofList(object data)
        {
            if (next == null)
            {
                next = new Node(data);
            }
            else
            {
                next.addToEndofList(data);
            }
        }
    }
}
