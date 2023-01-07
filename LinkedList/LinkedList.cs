using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedList
    {
        //Instance
        public Node head;

        //Adding Data to LinkedList
        public void Append(int data)
        {
            //Object of Node
            Node node = new Node(data);

            //Add Data
            if (this.head == null)
            { 
                this.head = node;
                Console.WriteLine("{0}: Inserted SuccessFully ", node.data);
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
                Console.WriteLine(node.data + ": Inserted SuccessFully");
            }

            //Displaying  LinkedList Data
        }
        public void Display()
        {
            //Head is Null then List is empty
            if (this.head == null)
            {
                Console.WriteLine("Linked List is Empty");
            }
            else
            {
                Node temp = head;
                while (temp != null)
                {
                    Console.WriteLine("Linked List Data is : " + temp.data);
                    temp = temp.next;
                }
            }
        }
    }
}
