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
            nm = Console.ReadLine();
            Node newnode = new Node();
            newnode.rollNumber = nim;
            newnode.name = nm;
            //if node to be inserted is the first node 
            if (START == null || nim <= START.rollNumber)
            {
                if ((START != null) && (nim==START.rollNumber))
                {
                    Console.WriteLine("\nDuplicate roll numbers not allowed \n");
                    return;
                    {
                        newnode.next = START;
                        START = newnode;
                        return;
         
                    }
                    //Located the position of the new node in the list 
                    Node previous, current;
                    previous = START;
                    current = START;

                    while ((current != null) && (nim >= current.rollNumber))
                    {
                        if (nim == current.rollNumber)
                        {
                            Console.WriteLine("\n Duplicate roll number not allowed\n");
                            return;
                        }
                        previous = current;
                        current = current.next;
                    }

                    /*once the above for loop is executed, prev and current are positioned in such a 
                      manner that the positon of the new node is added*/
                    newnode.next = current;
                    previous.next = newnode;
                }
            
            }
        }
    }
}
   
