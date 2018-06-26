using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Sorting
{
    class Radixsort : ISorting
    {
        public void SortArray(int[] mass)
        {
            int[] testMass = new int[mass.Length];
            Array.Copy(mass, testMass, mass.Length);

            System.Diagnostics.Stopwatch stopWatch = new System.Diagnostics.Stopwatch();
            stopWatch.Start();
            Sort(testMass);
            stopWatch.Stop();
            Console.WriteLine(stopWatch.Elapsed.TotalMilliseconds);

        }
        public void Sort(int[] mass)
        {
            ArrayList[] lists = new ArrayList[10];
            for (int i = 0; i < 10; ++i)
                lists[i] = new ArrayList();
            for (int step = 0; step < 10; ++step)
            {
                for (int i = 0; i < mass.Length; ++i)
                {
                    int temp = (mass[i] % (int)Math.Pow(10, step + 1)) /
                                                  (int)Math.Pow(10, step);
                    lists[temp].Add(mass[i]);
                }
                int k = 0;
                for (int i = 0; i < 10; ++i)
                {
                    for (int j = 0; j < lists[i].Count; ++j)
                    {
                        mass[k++] = (int)lists[i][j];
                    }
                }
                for (int i = 0; i < 10; ++i)
                    lists[i].Clear();
            }
        }
    }
}
