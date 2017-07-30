using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class StackLinkedList
    {
        private Node head;
        private int count;
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

        public void Push(string item)
        {
            var oldHead = head;
            head = new Node(item);
            head.next = oldHead;
            count++;
        }

        public string Pop()
        {
            if (head == null)
            {
                return string.Empty;
            }

            var tmp = head;
            head = head.next;
            var str = tmp.item;
            tmp = null;
            return str;
        }

        public bool IsEmpty()
        {
            return head == null;
        }

        public int Count()
        {
            return count;
        }
    }

    public class StackLinkedListTest
    {
        public static void Execute()
        {
            var sl = new StackLinkedList();
            sl.Push("hemang");
            sl.Push("is");
            sl.Push("my");
            sl.Push("name");

            System.Console.WriteLine(sl.Pop());
            System.Console.WriteLine(sl.Pop());
        }
    }
}
