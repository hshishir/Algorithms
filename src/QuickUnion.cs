using System;

namespace Algorithms
{
    public class QuickUnion
    {
        private int size;
        private int[] array;

        public QuickUnion(int l)
        {
            size = l;
            array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = i;
            }
        }

        public int Root(int p)
        {
            while (array[p] != p)
            {
                p = array[p];
            }

            return p;
        }

        public void Union(int p, int q)
        {
            int proot = Root(p);
            int qroot = Root(q);
            array[proot] = qroot;
        }

        public bool Connected(int p, int q)
        {
            var proot = Root(p);
            var qroot = Root(q);
            var result = proot == qroot;
            Console.WriteLine($"{p} root: {proot}");
            Console.WriteLine($"{q} root: {qroot}");
            Console.WriteLine($"{p} - {q}: {result}");
            return result;
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

    public class QuickUnionTest
    {
        public static void Execute()
        {
            var qu = new QuickUnion(10);
            qu.Display();
            qu.Union(4, 3);
            qu.Union(3, 8);
            qu.Union(6, 5);
            qu.Union(9, 4);
            qu.Union(2, 1);
            qu.Union(5, 0);
            qu.Union(7, 2);
            qu.Union(6, 1);
            qu.Union(7, 3);

            qu.Display();
        }
    }
}
