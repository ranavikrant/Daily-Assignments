using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    class Program1
    {
        static void Main(string[] args)
        {
            int[] arg = new int[50];
            Console.WriteLine("Enter the array size:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter your numbers:\t");
            for (int i = 0; i < n; i++)
            {

                arg[i] = Convert.ToInt32(Console.ReadLine());
            }
            Stopwatch stopwatch = Stopwatch.StartNew();
            for (int j = 0; j < arg.Length; j++)
            {
                for (int i = 0; i < arg.Length-j-1; i++)
                {
                    if (arg[i] > arg[i + 1])
                    {
                       int  t = arg[i + 1];
                        arg[i + 1] = arg[i];
                        arg[i] = t;
                    }
                }
            }
            stopwatch.Stop();
            Console.WriteLine("The Sorted Array :");
            for (int i = 0; i < n; i++)
            {
                Console.Write(arg[i] + " ");
            }


            Console.WriteLine(stopwatch.Elapsed.TotalMilliseconds);
           
            Console.ReadLine();
        }
    }
}
