using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class ShuffleSort<T>
    {
        public void Shuffle(T[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                var rand = new Random();
                var r = rand.Next(0, i);
                Common<T>.Exch(a, i, r);
            }
        }
    }

    public class ShuffleSortTest
    {
        public static void Execute()
        {
            var a = new int[] {1,2,3,4,5,6};
            var s = new ShuffleSort<int>();
            Common<int>.DisplayArray(a);
            s.Shuffle(a);
            Common<int>.DisplayArray(a);
        }
    }
 }
