﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singly_linked_list
{
    //each node consist of the information part and lik to the next 
    class Node
    {
        public int rollNumber;
        public string name;
        public Node next;

    }
    class list
    { 
        Node START;

        public list()
        {
            START = null;

        }
        public void addNote() //add a node in the list
        {
            int nim ;
            string nm;
            Console.Write("\nEnter the roll number of the student :");
            nim = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter the name off the student :");
            
           

        }
    }
}
   
