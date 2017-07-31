using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class StackArray<T>
    {
        private int count;
        private T[] array;

        public StackArray(int size)
        {
            array = new T[size];
        }

        public void Push(T item)
        {
            if (count == array.Length)
            {
                Resize(2 * array.Length);
            }

            array[count++] = item;
        }

        public T Pop()
        {
            if (count <= 0)
            {
                System.Console.WriteLine("Empty stack");
                return default(T);
            }

            if (count == array.Length / 4)
            {
                Resize(array.Length / 2);
            }
            
            return array[--count];
        }

        public int Count()
        {
            return count;
        }

        public int Length()
        {
            return array.Length;
        }

        public void Resize(int size)
        {
            System.Console.WriteLine($"Current array length: {array.Length}");
            System.Console.WriteLine($"Current item count: {count}");
            System.Console.WriteLine($"New array length: {size}");
            T[] newArray = new T[size];
            for (int i = 0; i < count; i++)
            {
                newArray[i] = array[i];
            }

            array = newArray;
        }
    }

    public class StackArrayTest
    {
        public static void Execute()
        {
            var sa = new StackArray<string>(2);
            System.Console.WriteLine($"Array length: {sa.Length()}");
            sa.Push("one");
            sa.Push("two");
            sa.Push("three");
            sa.Push("four");
            Console.WriteLine(sa.Pop());
            Console.WriteLine(sa.Pop());
            Console.WriteLine(sa.Pop());
            Console.WriteLine(sa.Pop());
            Console.WriteLine(sa.Pop());
        }
    }
}
