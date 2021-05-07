using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure_Linked_List
{/// <summary>
/// Creating Node Class
/// </summary>
    class Node
    {
        //Data to be enter
        public int data;
        //finding next node
        public Node next;

        //Adding Node Method
        //constructor call node class
        public Node(int d)
        {
            data = d;
            next = null;
        }
    }
}