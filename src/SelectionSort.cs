using System;

namespace Algorithms
{
    public class SelectionSort<T> where T : IComparable<T>
    {
        public static void Sort(T[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                int min = i;
                for (int j = i+1; j < a.Length; j++)
                {
                    if (a[j].CompareTo(a[min]) < 0)
                    {
                        min = j;
                    }
                }

                Exchange(a, i, min);
            }
        }

        private static void Exchange(T[] a, int i, int j)
        {
            var tmp = a[i];
            a[i] = a[j];
            a[j] = tmp;
        }
    }

    public class SelectionSortTest
    {
        public static void Execute()
        {
            var a = new int[] {2,3,6,5,1,4};
            SelectionSort<int>.Sort(a);
            System.Console.WriteLine("Complete");
        }
    }
}
