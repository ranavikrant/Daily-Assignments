using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Assignments1408
{
    class Program
    {
        static void Main(string[] args)
        {
             
            int array_length;

            Console.WriteLine("Enter the lenght of the array");
            array_length = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[array_length];

            Console.WriteLine("Enter array to be sorted");
            for (int i = 0; i < array_length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Stopwatch timer = Stopwatch.StartNew();
           BubbleSort bubble_sort_obj = new BubbleSort();
             bubble_sort_obj.bubble_sort(array, array_length);

            /*  TwoLoopSort two_loop_obj = new TwoLoopSort();
            two_loop_obj.sort(array, array_length);*/
            timer.Stop();
            Console.WriteLine("\nTime:{0}", timer.Elapsed);
            Console.ReadLine();
            

            
        }
    }
}
