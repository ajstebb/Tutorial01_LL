using FedsLinkedList;
using System;

public class Program
{
    static void Main(string[] args)
    {
        LinkedList linkedList = new LinkedList();

        Console.WriteLine("Adding items to the end of the list.");
        linkedList.addToEnd(4);
        linkedList.addToEnd(76);
        linkedList.addToEnd(1.117);
        linkedList.addToEnd(8);

        Console.WriteLine("Adding items to the beginning of the list.");
        linkedList.addToBeginning(-2);
        linkedList.addToBeginning(true);
        linkedList.addToBeginning("string");
        linkedList.addToBeginning(-20);
        linkedList.addToBeginning(-55);

        Console.WriteLine("Showing items in the list.");
        linkedList.printConsole();
        Console.WriteLine("\n");

        Console.WriteLine("Removing the head node.");
        linkedList.removeFromBeginning();
        linkedList.printConsole();

        Console.WriteLine("\n");
        
        Console.WriteLine("Removing the tail node.");
        linkedList.removeFromEnd();
        linkedList.printConsole();
        Console.WriteLine("\n");
    }
}