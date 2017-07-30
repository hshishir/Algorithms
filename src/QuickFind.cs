using System;
using System.Linq;

namespace Algorithms
{
    public class QuickFind
    {
        private int[] array;
        private int size;

        public QuickFind(int length)
        {
            size = length;
            array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = i;
            }
        }

        public void Union(int p, int q)
        {
            var ap = array[p];
            var aq = array[q];
            for (int i = 0; i < size; i++)
            {
                if (array[i] == ap)
                {
                    array[i] = aq;
                }
            }
        }

        public bool IsConnected(int p, int q)
        {
            return array[p] == array[q];
        }

        public void Display()
        {
            var str = string.Empty;
            foreach (var a in array)
            {
                str += $"{a} ";
            }

            Console.WriteLine(str);
        }
    }

    public class QuickFindTest
    {
        public static void Execute()
        {
            var uf = new QuickFind(10);
            uf.Display();

            uf.Union(0, 2);
            uf.Union(2, 3);
            uf.Union(2, 5);
            uf.Display();
            Console.WriteLine($"0-5 {uf.IsConnected(0, 5)}");
            Console.WriteLine($"5-3 {uf.IsConnected(5, 3)}");
            Console.WriteLine($"0-7 {uf.IsConnected(0, 7)}");
            Console.WriteLine($"3-8 {uf.IsConnected(3, 8)}");
        }
    }
}
