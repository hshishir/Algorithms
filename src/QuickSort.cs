using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class QuickSort<T> where T : IComparable<T>
    {
        public void Sort(T[] a, int lo, int hi)
        {
            if (lo >= hi)
            {
                return;
            }
            var p = Partition(a, lo, hi);
            Sort(a, lo, p-1);
            Sort(a, p + 1, hi);
        }

        public int Partition(T[] a, int lo, int hi)
        {
            var i = lo + 1;
            var j = hi;
            while (true)
            {
                while (a[i].CompareTo(a[lo]) < 0) { i++; }
                while (a[j].CompareTo(a[lo]) > 0) { j--; }
                if (i >= j)
                {
                    break;
                }

                Common<T>.Exch(a, i, j);
            }

            Common<T>.Exch(a, lo, j);
            return j;
        }
    }

    public class QuickSortTest
    {
        public static void Execute()
        {
            var a = new int[] {3,2,4,5,1,6};
            Common<int>.DisplayArray(a);
            var qs = new QuickSort<int>();
            qs.Sort(a, 0, a.Length - 1);
            Common<int>.DisplayArray(a);
        }
    }
}
