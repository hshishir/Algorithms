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
                first = 0;
                last = 0;
            }
            else if (first > 0)
            {
                first = first - 1;
            }
            else
            {
                first = array.Length - 1;
            }

            array[first] = data;
        }

        public void DeleteStart()
        {
            array[first] = default(T);
            if (first < array.Length - 1)
            {
                first = first + 1;
            }
            else
            {
                first = 0;
            }
        }

        public void DeleteEnd()
        {
            array[last] = default(T);
            if (last == 0)
            {
                last = array.Length - 1;
            }
            else
            {
                last = last - 1;
            }
        }

        public void AddEnd(T data)
        {
            if (first == -1)
            {
                last = 0;
                first = 0;
            }
            else if (last == array.Length - 1)
            {
                last = 0;
            }
            else
            {
                last++;
            }

            array[last] = data;
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

        public T GetLast()
        {
            return array[last];
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
            qa.Display();
            System.Console.WriteLine(qa.GetFirst());
            qa.DeleteStart();
            System.Console.WriteLine(qa.GetFirst());
            qa.DeleteStart();
            System.Console.WriteLine(qa.GetFirst());
            qa.Display();
        }
    }
}
