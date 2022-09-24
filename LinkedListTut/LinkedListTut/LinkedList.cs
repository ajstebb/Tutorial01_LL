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
        private Print _print = new Print();
        private Node _headNode;

        // I believe you said in the old project that an auto-implemented
        // property isn't the right way to do this, but I couldn't think of
        // another way. I feel like I'm doing this all wrong because we never finished
        // going through these concepts in the old project.
        public int Count { get; set; }

        // Constructor
        public LinkedList()
        {
            _headNode = null;
            Count = 0;
        }

        // This method prints node to console
        public void PrintConsole()
        {
            if (_headNode != null)
            {
                _headNode.PrintConsole();
            }

        }

        // This method adds a node to the end of the list
        public void AddToEnd(object data)
        {
            if (_headNode == null)
            {
                _headNode = new Node(data);
                Count++;
            }
            else
            {
                _headNode.AddToEndOfList(data);
                Count++;
            }
        }

        // This method adds a node to the beginning of the list
        public void AddToBeginning(object data)
        {
            if(_headNode == null)
            {
                _headNode = new Node(data);
                Count++;
            }
            else 
            {
                Node temp = new Node(data);
                temp.next = _headNode;
                _headNode = temp;
                Count++;
            }
        }

        // This method removes a node from the beginning of the list
        public void RemoveFromBeginning()
        {
            if (_headNode != null)
            {
                Node temp = _headNode;
                _headNode = temp.next;
                Count--;
            }
        }

        //This method removes a node from the end of the list
        public void RemoveFromEnd()
        {
            if (_headNode != null)
            {
                var temp = _headNode;
                Node prev = null;

                while (temp.next != null)
                {
                    prev = temp;
                    temp = temp.next;
                }

                if (prev != null)
                {
                    prev.next = null;
                    Count--;
                }
                else
                {
                    _headNode = null;
                    Count--;
                }
            }
        }

        // This method retrieves a node from the list using an index
        public Node RetrieveNodeAtIndex(int index)
        {
            if (index < 0 || index >= Count)
            {
                // I wanted to use the _print.log method here, but I didn't know what to return.
                throw new IndexOutOfRangeException("Index is out of range. Cannot retrieve a node.");
            }
            else
            {
                var counter = 0;
                var currentNode = _headNode;

                while (counter != index)
                {
                    currentNode = currentNode.next;
                    counter++;
                }

                return currentNode;
            }
        }

        // This method inserts a node at a given index
        public void InsertAtIndex(object data, int index)
        {
            if (index < 0 || index >= Count)
            {
                _print.log("Index is out of range. Cannot add the node.");
            }
            else if (index == 0)
            {
                AddToBeginning(data);
            }
            else if (index == Count - 1)
            {
                AddToEnd(data);
            }
            else
            {
                var counter = 0;
                var temp = _headNode;
                Node prev = null;
                var newNode = new Node(data);

                while (counter != index)
                {
                    prev = temp;
                    temp = temp.next;
                    counter++;
                }

                newNode.next = temp;
                prev.next = newNode;
                Count++;
            }
        }

        // This method removes a node at a given index
        public void RemoveAtIndex(int index)
        {
            if (index < 0 || index >= Count)
            {
                _print.log("Index is out of range. Cannot remove the node.");
            }
            else if (index == 0)
            {
                RemoveFromBeginning();
            }
            else if (index == Count - 1)
            {
                RemoveFromEnd();
            }
            else
            {
                var counter = 0;
                var temp = _headNode;
                Node prev = null;

                while (counter != index)
                {
                    prev = temp;
                    temp = temp.next;
                    counter++;
                }

                prev.next = temp.next;
                Count--;
            }
        }
    }
}
