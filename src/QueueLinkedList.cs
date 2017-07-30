using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class QueueLinkedList
    {
        private Node head;
        private Node tail;

        private class Node
        {
            public string item;
            public Node next;

            public Node(string str)
            {
                item = str;
                next = null;
            }
        }

        public void Enqueue(string item)
        {
            var node = new Node(item);
            if (head == null && tail == null)
            {
                head = node;
                tail = node;
            }
            else
            {
                tail.next = node;
                tail = node;
            }
        }

        public string Dequeue()
        {
            if (head == null)
            {
                Console.WriteLine("Empty queue");
                return string.Empty;
            }
            var node = head;
            head = node.next;
            var str = node.item;
            node = null;
            return str;
        }

        public void DisplayList()
        {
            var curr = head;
            var str = string.Empty;
            while (curr != null)
            {
                str += $"{curr.item}->";
                curr = curr.next;
            }

            Console.WriteLine(str);
        }
    }

    public class QueueLinkedListTest
    {
        public static void Execute()
        {
            var ql = new QueueLinkedList();
            ql.Enqueue("One");
            ql.Enqueue("Two");
            ql.Enqueue("Three");

            ql.DisplayList();
            ql.Dequeue();
            ql.DisplayList();
        }
    }
}
