using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anna_Baseley_Lab_18
{
    class LabList
    {
        public Node Head { set; get; }
        public Node Tail { set; get; }
        public int Count { set; get; }

        public void Add(string userInput) //what we use to initialize data for new node
        {
            //1. Make a new node
            Node newNode = new Node { Next = null, Data = userInput };
            if (Count == 0) //very first node
            {
                //2.
                Head = newNode;
                //3.
                Tail = newNode;
                //4.
                Count++;
            }
            else
            {
                //2.
                Tail.Next = newNode; //LINKS the nodes together
                Tail = newNode; //changing the tail location from the first node to the last.
                //3.
                Count++;
            }
        }

        public void removeAll(string UserInput)
        {
            Node node = Head;
            while (node.Data == UserInput)
            {
                Head = Head.Next;
                node = node.Next;
                Count--;
            }
            while (node != null)
            {
                while (node.Next != null && node.Next.Data == UserInput)
                {
                    node.Next = node.Next.Next;
                    Count--;
                }
                node = node.Next;
            }
        }

        public void PrintInfo()
        {
            Node node = Head;

            while (node != null)
            {
                Console.WriteLine(node.Data);
                node = node.Next;
            }

        }
    }
}
