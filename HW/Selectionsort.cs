using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class Selectionsort : ISorting
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
        public void Sort(int[] mass)
        {
            for (int i = 0; i < mass.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < mass.Length; j++)
                {
                    if (mass[j] < mass[min])
                    {
                        min = j;
                    }
                }
                int temp = mass[i];
                mass[i] = mass[min];
                mass[min] = temp;
            }
        }
    }
}
