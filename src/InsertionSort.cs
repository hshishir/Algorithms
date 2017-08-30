using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class InsertionSort<T> where T : IComparable<T>
    {
        public void Sort(T[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (a[j].CompareTo(a[j-1]) < 0)
                    {
                        Exchange(a, j, j-1);
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }

        private void Exchange(T[] array, int p, int q)
        {
            var tmp = array[p];
            array[p] = array[q];
            array[q] = tmp;
        }
    }

    public class InsertionSortTest
    {
        public static void Execute()
        {
            var a = new int[] {2,3,6,5,1,4};
            var isort = new InsertionSort<int>();
            isort.Sort(a);
            Console.WriteLine("Complete!");
        }
    }
}
