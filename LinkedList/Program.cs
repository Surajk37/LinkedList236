namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tWelcome To Linked List [Data Structure] Programs\n");
            while (true)
            {
                Console.WriteLine("Please Select option from below list");
                Console.WriteLine("\n1. Add Linked List \n2. Insert New Node \n3. Delete First Element \n4. Delete Last Element");
                int option = Convert.ToInt32(Console.ReadLine());
                //Calling Class LinkedList
                LinkedList linkedList = new LinkedList();
                switch (option)
                {
                    case 1:
                        linkedList.Add(56);
                        linkedList.Add(30);
                        linkedList.Add(70);
                        linkedList.Display();
                        break;
                    case 2:
                        linkedList.Add(56);
                        linkedList.Add(70);
                        Console.WriteLine("\n\tBefore Inserting new node to Linked List");
                        linkedList.Display();
                        linkedList.InsertAtParticularPosition(2, 30);  //inserting new node to linked list 
                        Console.WriteLine("\n\n\tAfter Inserting new node to Linked List");
                        linkedList.Display();
                        break;
                    case 3:
                        linkedList.Add(56);
                        linkedList.Add(30);
                        linkedList.Add(70);
                        Console.WriteLine("\n\tBefore Deleting node from Linked List");
                        linkedList.Display();
                        linkedList.POP();    //to delete a first node from linked list
                        Console.WriteLine("\n\n\tAfter Deleting First Node from  Linked List");
                        linkedList.Display();
                        break;
                    case 4:
                        linkedList.Add(56);
                        linkedList.Add(30);
                        linkedList.Add(70);
                        Console.WriteLine("\n\tBefore Deleting Element from Linked List");
                        linkedList.Display();
                        linkedList.PopLastElement();    //to delete a first Element from linked list
                        Console.WriteLine("\n\n\tAfter Deleting First Element from  Linked List");
                        linkedList.Display();
                        break;
                    default:
                        Console.WriteLine("Please enter valid option");
                        break;

                }
                Console.ReadLine();
            }
        }
    }
}