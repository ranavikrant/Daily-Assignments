using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleApplication7
{
   public class BubbleSort
    {
        public void bubbleSort(int[] arr)
        {


            Stopwatch timer = Stopwatch.StartNew();
            for (int i = 0, j = i + 1; i < arr.Length && j < arr.Length;)
            {
                bool is_sorted = true;
                if (arr[i] > arr[j])
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    i = 0;
                    is_sorted = false;
                    j = i + 1;
                }
                else if(is_sorted)
                {
                    i++;
                    j++;
                   
                }

            }
            timer.Stop();
            Console.WriteLine("Time Taken:{0}", timer.Elapsed.TotalMilliseconds);


        }

        public void normal(int[] arr)
        {
            Stopwatch timer = Stopwatch.StartNew();
            for (int x = 0; x < arr.Length; x++)

            {

                for (int y = 0; y < arr.Length-1; y++)

                {

                    if (arr[y] > arr[y + 1])

                    {

                        int temp = arr[y + 1];

                        arr[y + 1] = arr[y];

                        arr[y] = temp;

                    }

                }

            }
            timer.Stop();
            Console.WriteLine("Time Taken:{0}", timer.Elapsed.TotalMilliseconds);
        }
        
        public void swap(int i, int j, int[] a)
        {
            int temp;
            temp = a[i];
            a[i] = a[i + 1];
            a[i + 1] = temp;
        }



    }


}

