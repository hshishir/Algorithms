using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class InsertionSort<T> where T : IComparable<T>
    {
        private T[] array;

        public void Sort(T[] data)
        {
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (data[j].CompareTo(data[j-1]) < 0)
                    {
                        Exchange(data, j, j-1);
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
}
