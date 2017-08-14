using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace BubbleSort
{
    class BubbleSort_Class
    {
        public void bubble_sort()
        {

            int[] val = {09,76,56,43,23,28};
            int i;
            Console.WriteLine("The Array is : ");
            Stopwatch stopwatch = new Stopwatch();
            

            for (i = 0; i < val.Length; i++)
            {
                Console.Write("{0} ",val[i]);
            }
            Console.WriteLine("\n");
            i =0;
            int temp = 0;
            bool go = true;
            stopwatch.Start();
            while (i < val.Length - 1) 
            {
                if (val[i] > val[i + 1])
                {
                    temp = val[i];
                    val[i] = val[i + 1];
                    val[i + 1] = temp;
                    go = false;
                }
                i++;

                if (i >= val.Length - 1 && go == false)
                {
                    i = 0;
                    go = true;
                }
            }
            stopwatch.Stop();
            Console.WriteLine("Time taken:{0}ms", stopwatch.Elapsed.TotalMilliseconds);
            Console.WriteLine("\n");
            for (i = 0; i < val.Length; i++)
            {
                
                Console.Write(" {0} ",val[i]);
            }
            
        } 
    }
}
