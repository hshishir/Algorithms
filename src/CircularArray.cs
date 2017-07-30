using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class CircularArray<T>
    {
        private T[] array;
        private int count;

        public CircularArray(int size)
        {
            array = new T[size];
        }

        public void Add(T data)
        {
            if (count == array.Length)
            {
                count = 0;
            }

            array[count++] = data;
        }

        public T Get(int num)
        {
            var length = array.Length;
            var index = (num > length) ? num % length - 1 : num - 1;
            return array[index];
        }
    }

    public class CircularArrayTest
    {
        public static void Execute()
        {
            var carray = new CircularArray<int>(5);
            carray.Add(1);
            carray.Add(2);
            carray.Add(3);
            carray.Add(4);
            carray.Add(5);
            carray.Add(6);
            carray.Add(7);

            Console.WriteLine(carray.Get(7) == 7);
        }
    }
}
