namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tWelcome To Linked List [Data Structure] Programs\n");
             
            //Calling Class LinkedList
            LinkedList linkedList = new LinkedList(); 
           
            linkedList.Add(56);
            linkedList.Add(70);
            Console.WriteLine("\n\tBefore Inserting new node to Linked List");
            linkedList.Display();
            linkedList.InsertAtParticularPosition(2, 30);
            Console.WriteLine("\n\n\tAfter Inserting new node to Linked List");
            linkedList.Display();

            Console.ReadLine();
        }
    }
}