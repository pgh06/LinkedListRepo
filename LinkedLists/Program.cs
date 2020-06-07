using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    public class LinkListPractice
    {
        public Node Head { get; set; }
        public int Size { get; internal set; }

        public class Node
        {
            public object Data { get; set; }
            public Node Next { get; set; }

            public Node(object data)
            {
                Data = data;
            }
        }

        internal void AddFront(object data)
        {
            var newNode = new Node(data);

            if (Head == null)
            {
                Head = newNode;
                Size++;
                return;
            }

            newNode.Next = Head;
            Head = newNode;
            Size++;
        }

        internal Node GetFirst()
        {
            return Head;
        }

        internal Node GetLast()
        {
            Node current = Head;

            while (current.Next != null)
            {
                current = current.Next;
            }

            return current;
        }

        internal void AddBack(object data)
        {
            Node newNode = new Node(data);

            if (Head == null)
            {
                Head = newNode;
                Size++;
                return;
            }

            Node current = Head;

            while (current.Next != null)
            {
                current = current.Next;
            }

            current.Next = newNode;
            Size++;
        }

        internal void Clear()
        {
            Head = null;
            Size = 0;
        }

        internal void Delete(object data)
        {
            Node current = Head;

            if (Head == null)
            {
                return;
            }

            if (Head != null && Head.Data.Equals(data))
            {
                Head = current.Next;
                return;
            }

            while (current.Next != null)
            {
                var isDeletingNextNode = current.Next.Data.Equals(data);

                if (isDeletingNextNode)
                {
                    current.Next = current.Next.Next;
                    Size--;
                    return;
                }

                current = current.Next;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var linkedList = new LinkListPractice();

            // add head
            linkedList.AddFront(1);

            // add node to replace head
            linkedList.AddFront(2);

            // add node to replace head
            linkedList.AddFront(3);

            // add node to replace head
            linkedList.AddBack(4);

            // get first node
            var head = linkedList.GetFirst();

            // get last node
            var tail = linkedList.GetLast();

            // get size
            var size = linkedList.Size;

            // clear linked list
            //linkedList.Clear();

            // add node to replace head
            linkedList.AddBack(5);

            // delete specific value
            linkedList.Delete(2);
        }
    }
}
