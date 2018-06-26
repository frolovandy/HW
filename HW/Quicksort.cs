using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class Quicksort : ISorting
    {
        public void SortArray(int[] mass)
        {
            int[] testMass = new int[mass.Length];
            Array.Copy(mass, testMass, mass.Length);

            System.Diagnostics.Stopwatch stopWatch = new System.Diagnostics.Stopwatch();
            stopWatch.Start();
            Sort(testMass, 0, testMass.Length - 1);
            stopWatch.Stop();
            Console.WriteLine(stopWatch.Elapsed.TotalMilliseconds);
        }
        public void Sort(int[] array, int first, int last)
        {
            int p = array[(last - first) / 2 + first];
            int temp;
            int i = first, j = last;
            while (i <= j)
            {
                while (array[i] < p && i <= last) ++i;
                while (array[j] > p && j >= first) --j;
                if (i <= j)
                {
                    temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    ++i; --j;
                }
            }
            if (j > first) Sort(array, first, j);
            if (i < last) Sort(array, i, last);
        }
    }
}
