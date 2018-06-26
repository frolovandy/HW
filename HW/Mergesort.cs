using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class Mergesort : ISorting
    {
        public void SortArray(int[] mass)
        {
            int[] testMass = new int[mass.Length];
            Array.Copy(mass, testMass, mass.Length);

            System.Diagnostics.Stopwatch stopWatch = new System.Diagnostics.Stopwatch();
            stopWatch.Start();
            MergeSort(testMass, 0, testMass.Length - 1);
            stopWatch.Stop();
            Console.WriteLine(stopWatch.Elapsed.TotalMilliseconds);
        }
        void Merge(int[] array, int left, int mid, int right)
        {
            int[] temp = new int[array.Length];
            int i, left_end, num_elements, tmp_pos;

            left_end = (mid - 1);
            tmp_pos = left;
            num_elements = (right - left + 1);

            while ((left <= left_end) && (mid <= right))
            {
                if (array[left] <= array[mid])
                    temp[tmp_pos++] = array[left++];
                else
                    temp[tmp_pos++] = array[mid++];
            }

            while (left <= left_end)
                temp[tmp_pos++] = array[left++];

            while (mid <= right)
                temp[tmp_pos++] = array[mid++];

            for (i = 0; i < num_elements; i++)
            {
                array[right] = temp[right];
                right--;
            }
        }

        void MergeSort(int[] array, int left, int right)
        {
            int mid;

            if (right > left)
            {
                mid = (right + left) / 2;
                MergeSort(array, left, mid);
                MergeSort(array, (mid + 1), right);

                Merge(array, left, (mid + 1), right);
            }
        }
    }
}
