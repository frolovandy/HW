using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class TestArrays
    {

        public int[] randomArray(int length)
        {
            int[] array = new int[length];
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(0, 2000000000);
            }
            return array;
        }
        public int[] sortedArray(int length)
        {
            int[] array = new int[length];
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(0, 2000000000);
            }
            Array.Sort(array);
            return array;
        }

        public int[] reverseArray(int length)
        {
            int[] array = new int[length];
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(0, 2000000000);
            }
            Array.Sort(array);
            array.Reverse();
            return array;
        }         
    }
}
