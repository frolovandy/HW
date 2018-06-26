using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class Insertionsort : ISorting
    {
        public void SortArray(int[] mass)
        {
            int[] testMass = new int[mass.Length];
            Array.Copy(mass, testMass, mass.Length);
            System.Diagnostics.Stopwatch stopWatch = new System.Diagnostics.Stopwatch();
            stopWatch.Start();
            sort(testMass);
            stopWatch.Stop();
            Console.WriteLine(stopWatch.Elapsed.TotalMilliseconds);
            
        }
        void sort(int[] mass)
        {
            int[] testMass = new int[mass.Length];
            Array.Copy(mass, testMass, mass.Length);

            int elem, location;
            for (int i = 1; i < testMass.Length; i++)
            {
                elem = testMass[i];
                location = i - 1;
                while (location >= 0 && testMass[location] > elem)
                {
                    testMass[location + 1] = testMass[location];
                    location = location - 1;
                }
                testMass[location + 1] = elem;
            }
        }

    }
}
