namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tWelcome To Linked List [Data Structure] Programs\n");
             
            //Calling Class LinkedList
            LinkedList linkedList = new LinkedList(); 
            linkedList.Append(56);
            linkedList.Append(30);
            linkedList.Append(70);
            linkedList.Display();

            Console.ReadLine();
        }
    }
}