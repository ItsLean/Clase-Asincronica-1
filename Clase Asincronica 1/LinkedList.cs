using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_Asincronica_1
{
    public class LinkedList
    {
        private Node head;

        public LinkedList()
        {
            head = null;
        }

        public void AddLast(int data)
        {
            Node newNode = new Node(data);

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }

        public void AddFirst(int data)
        {
            Node newNode = new Node(data);
            newNode.Next = head;
            head = newNode;
        }

        public void DeleteWithValue(int data)
        {
            if (head == null) return;

            if (head.Data == data)
            {
                head = head.Next;
                return;
            }

            Node current = head;
            while (current.Next != null)
            {
                if (current.Next.Data == data)
                {
                    current.Next = current.Next.Next;
                    return;
                }
                current = current.Next;
            }
        }

        public void PrintList()
        {
            Node current = head;
            while (current != null)
            {
                Console.Write(current.Data + " -> ");
                current = current.Next;
            }
            Console.WriteLine("null");
        }
    }
}