using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    public class Queue_q
    {
        Node front;
        Node rear;
        public void Enqueue(int data)
        {
            Node node=new Node(data);
            if(front==null)
            {
                rear= node;
                front = rear;
            }
            else
            {
                rear.Next = node;
                rear = rear.Next;
            }
        }
        public void display()
        {
            if(front==null)
            {
                Console.WriteLine("Queue is empty");
            }
            else
            {
                Node temp= front;
                while(temp!=null)
                {
                    Console.WriteLine("|" + temp.data + "|");
                    temp = temp.Next;
                }
            }
        }
        public void Dequeue()
        {
            if (front == null)
            {
                Console.WriteLine("Queue is empty");
            }
            Console.WriteLine("{0} element is Dequeue", front.data);
            front = front.Next;
        }
    }
}
