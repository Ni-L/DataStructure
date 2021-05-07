using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure_Linked_List
{/// <summary>
/// Adding Method
/// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**********WELCOME TO LINKED LIST********");
            LinkedList list = new LinkedList();
            //list.InsertData(56);
            // list.InsertData(30);
            //list.InsertData(70);
            //Calling InsertFront 
            list.InserFront(70);
            list.InserFront(30);
            list.InserFront(56);
            //list.InsertAtParticularPosition(2, 30);
            list.DeleteFirstNode();
            list.Display();
            Console.ReadLine();
        }
    }
}
