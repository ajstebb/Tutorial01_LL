using FedsLinkedList;
using System;

public class Program
{
    static void Main(string[] args)
    {
        LinkedList linkedList = new LinkedList();

        Console.WriteLine("Adding items to the end of the list.");
        linkedList.AddToEnd(4);
        linkedList.AddToEnd(76);
        linkedList.AddToEnd(1.117);
        linkedList.AddToEnd(8);

        Console.WriteLine("Count: " + linkedList.Count);

        Console.WriteLine("Adding items to the beginning of the list.");
        linkedList.AddToBeginning(-2);
        linkedList.AddToBeginning(true);
        linkedList.AddToBeginning("string");
        linkedList.AddToBeginning(-20);
        linkedList.AddToBeginning(-55);

        Console.WriteLine("Count: " + linkedList.Count);

        Console.WriteLine("Showing items in the list.");
        linkedList.PrintConsole();
        Console.WriteLine("\n");

        Console.WriteLine("Removing the head node.");
        linkedList.RemoveFromBeginning();
        linkedList.PrintConsole();
        Console.WriteLine();
        Console.WriteLine("Count: " + linkedList.Count);
        Console.WriteLine("\n");

        Console.WriteLine("Removing the tail node.");
        linkedList.RemoveFromEnd();
        linkedList.PrintConsole();
        Console.WriteLine();
        Console.WriteLine("Count: " + linkedList.Count);
        Console.WriteLine("\n");

        Console.WriteLine("The value of the node at index 3 is {0}.", linkedList.RetrieveNodeAtIndex(3).data);
        Console.WriteLine("Adding 34 at index 3.");
        linkedList.InsertAtIndex(34, 3);
        linkedList.PrintConsole();
        Console.WriteLine();
        Console.WriteLine("The value of the node at index 3 is {0}.", linkedList.RetrieveNodeAtIndex(3).data);
        Console.WriteLine("Count: " + linkedList.Count);
        Console.WriteLine("\n");
    }
}