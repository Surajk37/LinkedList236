﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class Node
    {
        //Instance 
        public int data;      
        public Node next;
       
        //Creating constructor
        public Node(int data)       
        {
            this.data = data;
            this.next = null;
        }
    }
}
