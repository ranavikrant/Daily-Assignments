using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arg= new int[50];
            Console.WriteLine("Enter the array size:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter your numbers:\t");

            for (int i = 0; i < n; i++)
            {

                arg[i] = Convert.ToInt32(Console.ReadLine());
            }

            Stopwatch stopwatch = Stopwatch.StartNew();
            for (int i = 1; i < n; i++)
            {
                if (arg[i] < arg[i - 1])
                {
                    arg[i] = arg[i] + arg[i - 1];
                    arg[i - 1] = arg[i] - arg[i - 1];
                    arg[i] = arg[i] - arg[i - 1];
                    i = 0;
                }
            }
            stopwatch.Stop();
            for (int i = 0; i <n; i++)
            {
                Console.Write(arg[i] + " ");
            }
           
            Console.WriteLine(stopwatch.Elapsed.TotalMilliseconds);
            
            Console.ReadLine();
        }
    }
}
//Normal Bubble Sort time:   4.6105
//1 loop bubble sort time:   1.9748

