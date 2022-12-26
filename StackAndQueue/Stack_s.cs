using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    internal class Stack_s
    {
        Node top;
        public Stack_s()
        {
            this.top = null;
        }
        public void push(int data)
        {
            Node node = new Node(data);
            if(top ==null)
            {
                node.Next = null;
            }
            else
            {
                node.Next = this.top;
            }
            this.top = node;
            Console.WriteLine("{0} is pushed to stack", data);
        }
        public void Display()
        {
            Node temp= this.top;
            while(temp!= null)
            {
                Console.WriteLine("|" + temp.data + "|");
                temp = temp.Next;
            }
        }
        public void peek()
        {
            if (this.top == null)
            {
                Console.WriteLine("stack is empty");
            }
            else
            {
                Console.WriteLine("\n{0} is in top of the stack", top.data);
            }
        }
        public void pop()
        {
            if(this.top==null)
            {
                Console.WriteLine("stack is empty");
            }
            else
            {
               Console.WriteLine("value popped is {0}",top.data);
                top=top.Next;
            }
        }
    }
}
