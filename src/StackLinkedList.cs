using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class StackLinkedList<T>
    {
        private Node head;
        private int count;
        private class Node
        {
            public T data;
            public Node next;

            public Node(T item)
            {
                data = item;
                next = null;
            }
        }

        public void Push(T item)
        {
            var oldHead = head;
            head = new Node(item);
            head.next = oldHead;
            count++;
        }

        public T Pop()
        {
            if (head == null)
            {
                return default(T);
            }

            var tmp = head;
            head = head.next;
            var value = tmp.data;
            tmp = null;
            return value;
        }

        public bool IsEmpty()
        {
            return head == null;
        }

        public int Count()
        {
            return count;
        }

        public void DisplayList()
        {
            var curr = head;
            var str = string.Empty;
            while (curr != null)
            {
                str += $"{curr.data}->";
                curr = curr.next;
            }

            Console.WriteLine(str);
        }
    }

    public class StackLinkedListTest
    {
        public static void Execute()
        {
            var sl = new StackLinkedList<string>();
            sl.Push("one");
            sl.Push("two");
            sl.Push("three");
            sl.Push("four");
            sl.DisplayList();
            System.Console.WriteLine(sl.Pop());
            System.Console.WriteLine(sl.Pop());
            sl.DisplayList();
        }
    }
}
