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
        public void Add(int data)
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

        }
        //Adding Data In Particular Position
        public void InsertAtParticularPosition(int position, int data)
        {
            Node node = new Node(data);
            if (position < 1)
                Console.WriteLine("Invalid Position");
            else if (position == 1)
            {
                node.next = head;
                head = node;
            }
            else
            {
                Node temp = head;

                while (position > 2)
                {
                    temp = temp.next;
                    position--;
                }
                node.next = temp.next;
                temp.next = node;
            }
        }
        //Delete First element 
        public Node POP()
        {
            if (this.head == null)
                return null;
            this.head = this.head.next;
            return this.head;
        } 

        //Delete Last Element
        internal Node PopLastElement()
        {
            if (head == null)
                return null;
            if (head.next == null)
                return null;
            Node newNode = head;
            while (newNode.next.next != null)
            {
                newNode = newNode.next;
            }
            newNode.next = null;
            return head;
        }

        //Displaying  LinkedList Data
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
