using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure_Linked_List
{/// <summary>
/// Creating Linked List for Adding Elements 
/// </summary>
    class LinkedList
    {
        //Creating a node Equals to head, which will be pointing to the first element in linkedlist
        public Node head;
        public void InsertData(int new_data)
        {
            //Creating a object of node and adding data in node
            Node new_node = new Node(new_data);
            //if Head Equals to Null Then Add data 
            //fills the first position in linkedlist, when head points to nothing

            if (this.head == null)
            {
                this.head = new_node;
            }
            else
            {
                Node lastNode = GetLastNode();
                lastNode.next = new_node;
            }
            Console.WriteLine("inserted into list" + new_node.data);
        }
            public Node GetLastNode()
            {
                Node temp = this.head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                return temp;
            }

            internal void Display()
            {
                Node temp = this.head;
                if (temp == null)
                {
                    Console.WriteLine("Linked list is empty");
                    return;
                }
                else
                {
                    while (temp.next != null)
                    {
                        Console.Write(temp.data + "->");
                        temp = temp.next;
                    }
                    Console.WriteLine(temp.data);
                }
            }
    }
}
