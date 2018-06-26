using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class Shellsort : ISorting
    {
        public void SortArray(int[] mass)
        {
            {
                int[] testMass = new int[mass.Length];
                Array.Copy(mass, testMass, mass.Length);

                System.Diagnostics.Stopwatch stopWatch = new System.Diagnostics.Stopwatch();
                stopWatch.Start();
                Sort(testMass);
                stopWatch.Stop();
                Console.WriteLine(stopWatch.Elapsed.TotalMilliseconds);
            }
        }
        int increment(int[] inc)
        {
            int p1 =1, p2 =1, p3 = 1, s = -1;
            do
            {
                if (++s % 2 != 0)
                {
                    inc[s] = 8 * p1 - 6 * p2 + 1;
                }
                else
                {
                    inc[s] = 9 * p1 - 9 * p3 + 1;
                    p2 *= 2;
                    p3 *= 2;
                }
                p1 *= 2;
            } while (3 * inc[s] < inc.Length);

            return s > 0 ? --s : 0;
        }
        void Sort(int[] mass)
        {
            int inc, i, j;
            int[] seq = new int[mass.Length];

            int s = increment(seq);
            while (s >= 0)
            {
                inc = seq[s--];
                for (i = inc; i < mass.Length; i++)
                {
                    int temp = mass[i];
                    for (j = i - inc; (j >= 0) && (mass[j] > temp); j -= inc)
                        mass[j + inc] = mass[j];
                    mass[j + inc] = temp;
                }
            }
        }
    }
}