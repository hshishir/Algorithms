using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class Common<T>
    {
        public static void DisplayArray(T[] a)
        {
            var str = string.Empty;
            for (int i = 0; i < a.Length; i++)
            {

                str += ($"{a[i]} ");
            }

            System.Console.WriteLine(str);
        }

        public static void Exch(T[] a, int i, int j)
        {
            var tmp = a[i];
            a[i] = a[j];
            a[j] = tmp;
        }
    }
}
