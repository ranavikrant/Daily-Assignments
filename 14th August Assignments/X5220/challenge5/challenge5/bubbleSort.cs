using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge5
{
    class bubbleSort
    {
        public void bubble2()
        {
            //Int32[] numArray = new Int32[10];
            int i, j, temp, size;

            Console.WriteLine("Enter the size of array: ");
            size = Convert.ToInt16(Console.ReadLine());

            /*Console.WriteLine("Enter the elements in array to be sorted: ");
            for (i = 0; i < size; i++)
            {
                numArray[i] = Convert.ToInt16(Console.ReadLine());
            }*/

            int[] numArray= { 23, 54, 87, 2, 98, 12, 33, 32, 77, 1};

            var watch = System.Diagnostics.Stopwatch.StartNew();

                for (i = 1; i < 10; i++)
                {
                    bool flag = false;
                    for (j = 0; j < 10 - i; j++)
                    {
                        if (numArray[j] > numArray[j + 1])
                        {
                            flag = true;
                            temp = numArray[j + 1];
                            numArray[j + 1] = numArray[j];
                            numArray[j] = temp;
                        }
                    }

                    if (!flag)
                    {
                        return;
                    }
                }


            watch.Stop();
               var elapsedMs = watch.ElapsedMilliseconds;
           
                Console.WriteLine("Array after sorting: ");

                for (i = 0; i < 10; ++i)
                {
                    Console.WriteLine("{0}", numArray[i]);
                }
                Console.WriteLine("\n The time taken for execution in milliseconds(2 loops): {0}\n\n", watch.Elapsed);
        }

        public void bubble1()
        {
            int[] numArray = { 23, 54, 87, 2, 98, 12, 33, 32, 77, 1 };
            int j = 0;
            int prevI = 0;
            var watch = System.Diagnostics.Stopwatch.StartNew();
            for (int i = 0; i < (numArray.Length - 1); i++)
            {
                j++;
                if (j < numArray.Length)
                {
                    i = prevI;
                }
                else
                {
                    j = i + 1;
                }

                if (numArray[i] > numArray[j])
                {
                    int temp = numArray[i];
                    numArray[i] = numArray[j];
                    numArray[j] = temp;
                }
                prevI = i;

            }
            watch.Stop();
            Console.WriteLine("Sorted list :");

            for (int i = 0; i < numArray.Length; i++)
            {

                Console.Write("\t" + numArray[i]);
            }


            //Console.WriteLine("\n Time : " + watch1.Elapsed);

            Console.WriteLine("\n The time taken for execution in milliseconds (1 loop): {0}", watch.Elapsed);
        }

        public void bubbledo()
        {
            //Int32[] numArray = new Int32[10];
            int i, j, temp, size;

            Console.WriteLine("\n\nEnter the size of array: ");
            size = Convert.ToInt16(Console.ReadLine());

            /*Console.WriteLine("Enter the elements in array to be sorted: ");
            for (i = 0; i < size; i++)
            {
                numArray[i] = Convert.ToInt16(Console.ReadLine());
            }*/

            int[] numArray = { 23, 54, 87, 2, 98, 12, 33, 32, 77, 1 };

            var watch = System.Diagnostics.Stopwatch.StartNew();


            do
            {
                int sw = 0;

                for (i = 0; i < size - 1; i++)
                {

                    if (numArray[i] > numArray[i + 1])
                    {

                        temp = numArray[i];
                        numArray[i] = numArray[i + 1];
                        numArray[i + 1] = temp;


                        sw = i + 1;
                    }
                }

                size = sw;
            }


            while (size > 1);

           
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;

            Console.WriteLine("Array after sorting: ");

            for (i = 0; i < 10; ++i)
            {
                Console.WriteLine("{0}", numArray[i]);
            }
            Console.WriteLine("\n The time taken for execution in milliseconds (doWhile): {0}", watch.Elapsed);
        }
    }
            

}























    

            