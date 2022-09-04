using FedsLinkedList;

public class Program
{
    static void Main(string[] args)
    {
        LinkedList linkedList = new LinkedList();
        linkedList.addToEnd(4);
        linkedList.addToEnd(76);
        linkedList.addToEnd(1.117);
        linkedList.addToEnd(8);
        linkedList.addToBeginning(-2);
        linkedList.addToBeginning(true);
        linkedList.addToBeginning("string");
        linkedList.addToBeginning(-20);
        linkedList.addToBeginning(-55);

        linkedList.printConsole();
    }
}