using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Assignment_DAY6
{
    class BubbleSort
    {
        public void Sort(int[] numbers)
        {
            //---------TIME COMPLEXITY------------
            //METHOD 1--> while{for}:    1080-1300ms for 20k numbers
            //METHOD 2--> do-while{for}: 2850-3100ms for 20k elements
            //METHOD 3--> Traditional:   3100-3300ms for 20k numbers


            //INITIALIZATION
            Stopwatch watch = new Stopwatch();
            int temp = 0;
            bool swapped = true;



            // ---------METHOD 1--> WHILE{FOR}---------------
            int num = numbers.Length - 1;
            watch.Start();
            while (num > 0)
            {
                swapped = false;
                for (int i = 1; i <= num ;i++)
                {
                    if (numbers[i-1] > numbers[i])
                    {
                        swapped = true;
                        temp = numbers[i-1];
                        numbers[i-1] = numbers[i];
                        numbers[i] = temp;
                    }
                }
                num = num - 1;
            }
            watch.Stop();
            Console.Write("Sorted Numbers are :");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("{0}, ", numbers[i]);
            }
            Console.Write("Time:{0}ms", watch.Elapsed);      
            Console.ReadLine();


            //---------------METHOD 2--> DO-WHILE{FOR}--------------
            watch.Start();
            do
            {
                swapped = false;
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    if (numbers[i] > numbers[i + 1])
                    {
                        temp = numbers[i + 1];
                        numbers[i + 1] = numbers[i];
                        numbers[i] = temp;
                        swapped = true;
                    }
                }
            } while (swapped == true);
            watch.Stop();
            Console.Write("Sorted Numbers are :");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("{0}, ", numbers[i]);
            }
            Console.Write("Time:{0}ms", watch.Elapsed);
            Console.ReadLine();


            // ------------METHOD 3--> TRADITIONAL METHOD--------------
            watch.Start();
            for (int j = 0; j <= numbers.Length - 2; j++)
            {
                for (int i = 0; i <= numbers.Length - 2; i++)
                {
                    if (numbers[i] > numbers[i + 1])
                    {
                        temp = numbers[i + 1];
                        numbers[i + 1] = numbers[i];
                        numbers[i] = temp;
                    }
                }
            }
            watch.Stop();
            Console.Write("Sorted Numbers are :");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("{0}, ", numbers[i]);
            }
            Console.Write("Time:{0}ms", watch.Elapsed);
            Console.ReadLine();


            //COMPLEXITY CALCULATION & SORTED ARRAY DISPLAY
            //Console.Write("Sorted Numbers are :");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write("{0}, ", numbers[i]);
            //}
            //Console.Write("Time:{0}ms", watch.ElapsedMilliseconds);
            //watch.Stop();
            //Console.ReadLine();

        }
    }
}
