using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5_assignments
{
    class BubbleSort
    {


        public void bubblesort(int[] arr, int n)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            int temp;
            for (int i = 1; i < n ; i++)
            {
                for (int j = 1; j <n-1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            stopwatch.Stop();
            Console.WriteLine("Array after sorting");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("time required for normal sorting" + stopwatch.Elapsed);
        }



        public void bubblesort_optimized(int[] arr, int n)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            for (int i = 0; i < n - 1; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    int tmp;
                    tmp = arr[i + 1];
                    arr[i + 1] = arr[i];
                    arr[i] = tmp;
                    i = 0;
                }
            }

            stopwatch.Stop();
            Console.WriteLine("Array after sorting");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i]);
              
            }
            Console.WriteLine("time required for optimized sorting" + stopwatch.Elapsed);
        }
       
            }
}

