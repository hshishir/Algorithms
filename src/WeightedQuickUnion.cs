using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class WeightedQuickUnion
    {
        private int size;
        private int[] array;

        public WeightedQuickUnion(int length)
        {
            size = length;
            array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = i;
            }
        }

        private int Root(int p)
        {
            while (array[p] != p)
            {
                p = array[p];
            }

            return array[p];
        }

        private int Weight(int p)
        {
            int weight = 1;
            
            return weight;
        }

        public void Union(int p, int q)
        {
            var proot = Root(p);
            var qroot = Root(q);
            var pw = Weight(p);
            var qw = Weight(q);

            if (pw < qw)
            {
                proot = qroot;
            }
            else
            {
                qroot = proot;
            }
        }
    }
}
