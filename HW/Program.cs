using Sorting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayLength = { 100, 500, 1000, 5000, 10000, 50000, 100000 };

            Insertionsort insertionSort = new Insertionsort();
            Mergesort mergeSort = new Mergesort();
            Quicksort quickSort = new Quicksort();
            Radixsort radixSort = new Radixsort();
            Selectionsort selectionSort = new Selectionsort();
            Shellsort shellSort = new Shellsort();
            TestArrays arrayGen = new TestArrays();

            for (int i = 0; i < arrayLength.Length; i++)
            {
                int[] mass = arrayGen.sortedArray(arrayLength[i]);
                insertionSort.SortArray(mass);
                mergeSort.SortArray(mass);
                quickSort.SortArray(mass);
                radixSort.SortArray(mass);
                selectionSort.SortArray(mass);
                shellSort.SortArray(mass);
            }
            for (int i = 0; i < arrayLength.Length; i++)
            {
                int[] mass = arrayGen.randomArray(arrayLength[i]);
                insertionSort.SortArray(mass);
                mergeSort.SortArray(mass);
                quickSort.SortArray(mass);
                radixSort.SortArray(mass);
                selectionSort.SortArray(mass);
                shellSort.SortArray(mass);
            }
            for (int i = 0; i < arrayLength.Length; i++)
            {
                int[] mass = arrayGen.reverseArray(arrayLength[i]);
                insertionSort.SortArray(mass);
                mergeSort.SortArray(mass);
                quickSort.SortArray(mass);
                radixSort.SortArray(mass);
                selectionSort.SortArray(mass);
                shellSort.SortArray(mass);
            }
        }
    }   
}
