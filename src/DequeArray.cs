using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class DequeArray<T>
    {
        private T[] array;
        private int first;
        private int last;

        public DequeArray(int size)
        {
            array = new T[size];
            first = -1;
            last = 0;
        }

        public void AddStart(T data)
        {
            if (first == -1)
            {
                array[++first] = data;
            }
            else if (first > 0)
            {
                array[--first] = data;
            }
            else
            {
                first = array.Length - 1;
                array[first] = data;
            }
        }

        public void Display()
        {
            var str = string.Empty;
            for (int i = 0; i < array.Length; i++)
            {
                str += $"{array[i]} ";
            }

            System.Console.WriteLine(str);
        }

        public T GetFirst()
        {
            return array[first];
        }
    }

    public class DequeueArrayTest
    {
        public static void Execute()
        {
            var qa = new DequeArray<int>(4);
            qa.AddStart(1);
            qa.AddStart(2);
            qa.AddStart(3);
            qa.AddStart(4);
            qa.AddStart(5);

            qa.Display();
        }
    }
}
