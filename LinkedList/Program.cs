namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tWelcome To Linked List [Data Structure] Programs\n");
             
            //Calling Class LinkedList
            LinkedList linkedList = new LinkedList(); 
            linkedList.Add(70);
            linkedList.Add(30);
            linkedList.Add(56);
            linkedList.Display();

            Console.ReadLine();
        }
    }
}