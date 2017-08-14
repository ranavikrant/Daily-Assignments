using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aug_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr;
            int[] arr1;
            int count;

            Console.WriteLine("Enter Count of Numbers:");
            count = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter {0} Elements: ",count); 
            arr = new int[count];
            arr1 = new int[count];
            for (int i = 0; i < count; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                arr1[i] = arr[i];
            }

            BubbleSort bSort = new BubbleSort();

            var watch = System.Diagnostics.Stopwatch.StartNew();
            arr = bSort.SortNormal(arr);
            watch.Stop();
            Console.WriteLine("Time Taken for Normal sort: {0}", watch.Elapsed);

            watch = System.Diagnostics.Stopwatch.StartNew();
            arr = bSort.SortOptimized(arr1);
            watch.Stop();
            Console.WriteLine("Time Taken for Optimized Sort: {0}", watch.Elapsed);

            Console.Read();

        }
    }
}
