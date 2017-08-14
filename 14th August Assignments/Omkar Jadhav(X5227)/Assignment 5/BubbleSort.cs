using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    class BubbleSort
    {
        int i, j;
        Stopwatch stopWatch = new Stopwatch();

        //Bubble Sort using Single Loop 
        public void SingleLoopBubbleSort(int [] ElementArray)
        {             
                stopWatch.Start();
                for (i = 1; i < ElementArray.Length; i++)
                {
                    if (ElementArray[i] < ElementArray[i-1])
                    {
                        ElementArray[i] = ElementArray[i] + ElementArray[i - 1];       
                        ElementArray[i - 1] = ElementArray[i] - ElementArray[i - 1];
                        ElementArray[i] = ElementArray[i] - ElementArray[i - 1];
                        i = 0;
                    }
                }
                stopWatch.Stop();

                Console.WriteLine("Time Taken using Single Loop : {0}", stopWatch.Elapsed);
                
                //Dispalying sorted elements
                Console.WriteLine("Elements in ascending order : ");
                for (i = 0; i < ElementArray.Length; i++)
                {
                    Console.WriteLine(ElementArray[i]);
                }
        }


        //Bubble Sort using Multiple Loops 
        public void MultipleLoopBubbleSort(int[] ElementArray)
        {
            stopWatch.Start();
            for (j = 0; j <= ElementArray.Length - 1; j++)
            {
                for (i = 0; i <= ElementArray.Length - 2; i++)
                {
                    if (ElementArray[i] > ElementArray[i + 1])
                    {
                        ElementArray[i] = ElementArray[i] + ElementArray[i + 1];
                        ElementArray[i + 1] = ElementArray[i] - ElementArray[i + 1];
                        ElementArray[i] = ElementArray[i] - ElementArray[i + 1];
                    }
                }
            }
            stopWatch.Stop();

            Console.WriteLine("Time Taken using Multiple Loops : {0}", stopWatch.Elapsed);
        }


        //Taking input from user
        public void InputForBubbleSort()
        {
            Console.Write("Enter the total number of elements to be sorted in ascending order : ");
            try
            {
                int TotalElements = Convert.ToInt16(Console.ReadLine());
                int[] ElementArray = new int[TotalElements];
                int i = 0;
                Console.WriteLine("Enter the elements : ");
                while (i < (TotalElements))
                {
                    ElementArray[i] = Convert.ToInt16(Console.ReadLine());
                    i++;
                }

                //Method Calls
                SingleLoopBubbleSort(ElementArray);
                MultipleLoopBubbleSort(ElementArray); 
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

