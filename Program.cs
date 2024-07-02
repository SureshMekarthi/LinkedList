using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 12, 5, 8, 7 };
            LinkedList head = DeleteHead(head);
        }
        private static Node DeleteHead(Node head)
        {
            if(head == null)
            {
                return head;
            }
            head = head.Next;
            return head;
        }

    }
}
