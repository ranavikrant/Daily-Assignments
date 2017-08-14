using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConSorting
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
            Console.WriteLine("Normal Time Taken: {0}", watch.Elapsed);

            watch.Reset();

            watch = System.Diagnostics.Stopwatch.StartNew();
            arr = bSort.SortOptimized(arr1);
            watch.Stop();
            Console.WriteLine("Optimized Time Taken: {0}", watch.Elapsed);

            Console.Read();
        }
    }

    public class BubbleSort
    {
        public int[] SortOptimized(int[] numbers)
        {
            bool swapped = false;
            for (int i = 0, j = 1 ; i < numbers.Length - 1; j++)
            {
                if(numbers[i] > numbers[j])
                {
                    int tmp = numbers[i];
                    numbers[i] = numbers[j];
                    numbers[j] = tmp;
                    swapped = true;
                }

                if(j == numbers.Length - 1)
                {                    
                    i++;
                    j = i;
                    if (!swapped)
                    {
                        swapped = false;
                        break;
                    }
                }
            }
            return numbers;
        }

        public int[] SortNormal(int[] numbers)
        {
            for(int i = 0; i < numbers.Length - 1; i++)
            {
                bool swaped = false;
                for(int j = i; j < numbers.Length; j++)
                {
                    if(numbers[i] > numbers[j])
                    {
                        int tmp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = tmp;
                        swaped = true;
                    }
                }
                if (!swaped)
                    break;
            }
            return numbers;
        }
    }
}
