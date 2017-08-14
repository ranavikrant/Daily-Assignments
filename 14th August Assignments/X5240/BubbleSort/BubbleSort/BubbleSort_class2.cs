using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace BubbleSort
{
    class BubbleSort_class2
    {public void Bubble_sort()
        {
            int[] a = { 09, 76, 56, 43, 23, 28 };
            int t;
            Console.WriteLine("The Array is : ");
            Stopwatch stopwatch = new Stopwatch();
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
            stopwatch.Start();
            for (int j = 0; j <= a.Length - 2; j++)
            {
                for (int i = 0; i <= a.Length - 2; i++)
                {
                    if (a[i] > a[i + 1])
                    {
                        t = a[i + 1];
                        a[i + 1] = a[i];
                        a[i] = t;
                    }
                }
            }
            stopwatch.Stop();
            Console.WriteLine("Time taken:{0}ms", stopwatch.Elapsed.TotalMilliseconds);
            Console.WriteLine("The Sorted Array :");
            foreach (int aray in a)
                Console.Write(aray + " ");
            Console.ReadLine();
            stopwatch.Stop();
            Console.WriteLine("{0}", stopwatch.Elapsed);
        }
    }
}
