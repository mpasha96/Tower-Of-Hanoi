using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tower
{
    public class stack
    {
        Node node;
        public stack()
        {
            node = null;
        }
        int c = 0;
        public void Push(int data)
        {
            c++;

            if (node == null)
            {
                node = new Node(data);

            }
            else
            {
                Node first = new Node(data);
                first.next = node;
                node = first;
            }


        }
        public int Pop()
        {
            Node first = node;
            node = node.next;
            return first.data;
        }

        public int Peek()
        {
            return node.data;
        }

    }
    class Node
    {
        public int data;
        public Node next;

        public Node(int data)
        {
            this.data = data;
        }

    }
}

