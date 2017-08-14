using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace Assignments_1408
{
    class Bubble_sort_two_loops
    {
        public void sort()
        {
            int temp;
            Console.WriteLine("Enter length of array:");
            int array_length = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[array_length];

            Console.WriteLine("Enter array to be sorted");
            for (int i = 0; i < array_length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Two loops: Unsorted Array: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            Stopwatch stopwatch = Stopwatch.StartNew();
            for (int outer = 0; outer <= array.Length - 2; outer++)
            {
                for (int inner = 0; inner <= array.Length - 2; inner++)
                {
                    if (array[inner] > array[inner + 1])
                    {
                        temp = array[inner + 1];
                        array[inner + 1] = array[inner];
                        array[inner] = temp;
                    }
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
