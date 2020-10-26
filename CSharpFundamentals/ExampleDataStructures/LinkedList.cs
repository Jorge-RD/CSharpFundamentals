using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpFundamentals.ExampleDataStructures
{
    [System.Runtime.InteropServices.Guid("8DA2D8EF-4A70-4066-AA68-30FA57F70A80")]
    public class LinkedList
    {
        private int data;
        private LinkedList next;
        public LinkedList()
        {
            data = 0;
            next = null;
        }
        public LinkedList(int value)
        {
            data = value;
            next = null;
        }
        public LinkedList InsertNext(int value)
        {

            LinkedList node = new LinkedList(value);
            if (this.next == null)
            {
                node.next = null;
                this.next = node;
            }
            else
            {
                LinkedList temp = this.next;
                node.next = temp;
                this.next = node;
            }
            return node;
        }
        public int DeleteNext()
        {
            if (next == null)
                return 0;
            LinkedList node = this.next;
            this.next = this.next.next;
            node = null;
            return 1;
        }
        public void Traverse(LinkedList node)
        {
            if (node == null)
                node = this;
            System.Console.WriteLine("Traversing :");
            while (node != null)
            {
                System.Console.WriteLine(node.data);
                node = node.next;
            }
        }
        public void RunLinkedList()
        {
            LinkedList node1 = new LinkedList(11);
            LinkedList node2 = node1.InsertNext(12);
            LinkedList node3 = node2.InsertNext(13);
            LinkedList node4 = node3.InsertNext(14);
            LinkedList node5 = node4.InsertNext(15);
            node1.Traverse(null);
            Console.WriteLine("Deleting !!");
            node3.DeleteNext();
            node2.Traverse(null);
            System.Console.ReadLine();
        }
    }
}
