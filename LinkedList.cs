using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class LinkedList
    {
        public Node Head { get; set; }

        public LinkedList()
        {
            this.Head = null;
        }
        public void Add(int data)
        {
            Node newNode= new Node(data);
            if(Head == null)
            {
                Head = newNode;
            }
            else
            {
                Node current = Head;
                while(current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }

        public void Remove(int data)
        {
            if (Head == null)
            {
                return;
            }
            Head = Head.Next;
        }
        public void PrintList()
        {
            Node current = Head;
            while (current !=null)
                {
                Console.WriteLine(current.Data);
                current = current.Next;
            }
            Console.WriteLine();
        }
    }
}
