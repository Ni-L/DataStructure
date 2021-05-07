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
            list.InsertData(56);
            list.InsertData(30);
            list.InsertData(70);
            list.Display();
            Console.ReadLine();
        }
    }
}
