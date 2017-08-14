using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14thAug
{
    class bubbleSort
    {
       /* public void sortArray()
        {
          
            int[] a= { 1, 6, 2, 8, 3, 4, 69, 0, 26, 91 };
          //  bool flag = false; 
            var watch = System.Diagnostics.Stopwatch.StartNew();
            for (int i = 1; i < a.Length; i++)
            {
                for (int j = 0; j < a.Length-i; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                     //  flag = true;
                        a[j] = a[j] + a[j + 1];
                        a[j + 1] = a[j] - a[j + 1];
                        a[j] = a[j] - a[j + 1];
                    }
                }

            }
            watch.Stop();
                 
            Console.WriteLine("Time taken : " + watch.Elapsed);
            foreach (var item in a)
            {
                Console.Write(item + "\t");
            }
        }

        public void sortArray1()
        {

            int[] a = { 1, 6, 2, 8, 3, 4, 69, 0, 26, 91 };
            var watch = System.Diagnostics.Stopwatch.StartNew();
            int j = 0;
            int prevI = 0;
            for (int i = 0; i < a.Length - 1; i++)
            {
                j++;
                if (j < a.Length)
                {
                    i = prevI;
                }
                else
                {
                    j = i + 1;
                }

                if (a[i] > a[j])
                {
                    int temp = a[i];
                    a[i] = a[j];
                    a[j] = temp;
                }
                prevI = i;

            }
            watch.Stop();

            Console.WriteLine("Time taken : " + watch.Elapsed);
            foreach (var item in a)
            {
                Console.Write(item + "\t");
            }
        }
        */
        public void sortArray2()
        {

            int[] a = { 1, 6, 2, 8, 3, 4, 69, 0, 26, 91 };
            int n = a.Length;
            int j;
            var watch = System.Diagnostics.Stopwatch.StartNew();
            do
            {

                int sw = 0;
                for ( j = 0; j < a.Length - 1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        //  flag = true;
                        a[j] = a[j] + a[j + 1];
                        a[j + 1] = a[j] - a[j + 1];
                        a[j] = a[j] - a[j + 1];

                        sw = j + 1;

                    }
                }
                n = sw;

            } while (n > 1);
            watch.Stop();

            Console.WriteLine("Time taken : " + watch.Elapsed);
            foreach (var item in a)
            {
                Console.Write(item + "\t");
            }
        }
    }
}
