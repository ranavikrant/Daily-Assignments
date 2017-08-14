using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Assignments_1408
{
    class Bubble_sort_one_loop
    {
        public void sort()
        {
            Console.WriteLine("Enter length of array:");
            int array_length = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[array_length];

            Console.WriteLine("Enter array to be sorted");
            for (int i = 0; i < array_length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }


            int temp = 0;
            int j = 0;
            Console.WriteLine("Single Loop: Unsorted Array: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            Stopwatch stopwatch = Stopwatch.StartNew();
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    temp = array[i];
                    array[i] = array[i + 1];
                    array[i + 1] = temp;
                    i = -1;
                }
            }
            stopwatch.Stop();

            Console.WriteLine("Sorted Array: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine(stopwatch.Elapsed);
            Console.ReadLine();
        }
    }
}
