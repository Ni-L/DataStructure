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
        public void InserFront(int new_data)
        {
            //object is created for adding data in node class
            Node new_node = new Node(new_data);
            //head address is added in newly created node, hence the initial head is coming at last, and data is inserted at left
            new_node.next = this.head;
            this.head = new_node;
            // Console.WriteLine("inserted into front" + new_node);

        }

        //Creating Method For Deleteing Element
        internal Node DeleteFirstNode()
        {
            if (this.head == null)
            {
                return null;
            }
            this.head = this.head.next;
            return this.head;
        }
        //Creating Deleting LSst Node Method
        public Node DeleteLastNode()
        {
            Node newNode = this.head;
            if (this.head == null)
            {
                return null;
            }
            if (this.head.next == null)
            {
                this.head = null;
                return null;
            }
            while (newNode.next.next != null)
            {
                newNode = newNode.next;
            }
            newNode.next = null;
            return newNode;
        }
        //Adding Searching Method
        public bool Search(int input)
        {
            bool flag = false;
            if (head == null)
                Console.WriteLine("List is Empty");
            else
            {
                Node temp = head;
                while (temp != null)
                {
                    if (temp.data == input)
                    {
                        Console.WriteLine("The element is present");
                        flag = true;
                        break;
                    }
                    temp = temp.next;
                }
                if (!flag)
                    Console.WriteLine("The Element is Absent");
            }
            return flag;
        }
        //Adding InsertAfter Method
        public bool InsertAfter(int data, int after)
        {
            bool flag = false;
            if (head == null)
                Console.WriteLine("List is Empty");
            else
            {
                Node temp = head;
                while (temp != null)
                {
                    if (temp.data == after)
                    {
                        Node newNode = new Node(data);
                        newNode.next = temp.next;
                        temp.next = newNode;
                        flag = true;
                        break;
                    }
                    temp = temp.next;
                }
                if (!flag)
                    Console.WriteLine("The Element is Absent");
            }
            return flag;
        }
        //Adding Method Count 
        public int Count()
        {
            int count = 0;

            Node temp = head;
            while (temp != null)
            {
                temp = temp.next;
                count++;
            }
            Console.WriteLine($"Linked List Count is {count}");
            return count;
        }

        //Adding Delete Method Delete 
        public bool DeleteAnyData(int data)     //delete data
        {
            bool flag = false;
            int count = 0;

            if (head == null)
                Console.WriteLine("List is Empty");
            else
            {
                Node temp = head;
                Node previousNode = null;
                while (temp != null)
                {
                    count++;
                    if (temp.data == data)
                    {
                        if (count == 1)
                        {
                            head = temp.next;
                        }
                        else
                        {
                            previousNode.next = temp.next;
                        }
                        flag = true;
                        break;
                    }
                    previousNode = temp;
                    temp = temp.next;
                }
                if (!flag)
                    Console.WriteLine("The Element is Absent");
            }
            return flag;
        }
        //Adding Method Size
        public int Size()   //specify size
        {
            int count = 0;

            Node temp = head;
            while (temp != null)
            {
                temp = temp.next;
                count++;
            }

            return count;
        }
        //for sorting
        public Node LinkedListSorted(Node head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }
            Node temp = head;
            Node slow = head;
            Node fast = head;
            while (fast != null && fast.next != null)
            {
                temp = slow;
                slow = slow.next;
                fast = fast.next.next;

            }
            temp.next = null;
            Node leftside = LinkedListSorted(head);
            Node rightside = LinkedListSorted(slow);
            return Merge(leftside, rightside);
        }
        //for merging
        public Node Merge(Node l1, Node l2)
        {
            Node sorted_temp = new Node();
            Node current_node = sorted_temp;

            while (l1 != null && l2 != null)
            {
                if (l1.data < l2.data)
                {
                    current_node.next = l1;

                    l1 = l1.next;
                }
                else
                {
                    current_node.next = l2;

                    l2 = l2.next;
                }
                current_node = current_node.next;
            }

            if (l1 != null)
            {
                current_node.next = l1;
                l1 = l1.next;
            }

            if (l2 != null)
            {
                current_node.next = l2;
                l2 = l2.next;
            }

            return sorted_temp.next;

        }


        //Creating Dispaly Method
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
                        Console.Write(temp.data + "-->>");
                        temp = temp.next;
                    }
                    Console.WriteLine( temp.data);
                }
        }
    }
}
