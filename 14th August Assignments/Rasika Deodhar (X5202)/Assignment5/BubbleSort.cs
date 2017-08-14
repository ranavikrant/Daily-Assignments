using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class BubbleSort
    {
        public int temp;

        public void bubble_sort_TwoLoops(int[] numbers,int time_complexity)
        {
            Console.WriteLine("Length = " + numbers.Length);
            Console.WriteLine("Before sort = " );
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + "\t");
            }
            time_complexity++;

            for (int i = 0; i < numbers.Length; i++)
            {
                time_complexity++;
                for (int j = 0; j < numbers.Length-1; j++)
                {
                    time_complexity++;
                    if (numbers[j]>numbers[j+1])
                    {
                        time_complexity++;

                        temp = numbers[j];
                        numbers[j] = numbers[j+1];
                        numbers[j+1] = temp;
                    }
                    else
                    {
                        time_complexity++;
                    }
                }
                time_complexity++;
            }
            time_complexity++;
            Console.WriteLine("\n");
            Console.WriteLine("Sorted array is-");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + "\t");
            }
            Console.WriteLine("Time complexity is = " + time_complexity);    
        }

        public void bubble_sort_SingleLoop(int[] numbers,int time_complexity)
        {
            int i, j;
            Console.WriteLine("Length = " + numbers.Length);
            Console.WriteLine("Before sort = ");
            for (i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + "\t");
            }

            i = 0; j=0;
            while(i<numbers.Length && j < numbers.Length - 1)
            {
                time_complexity++;
                if(numbers[j]>numbers[j+1] )
                {
                    time_complexity++;
                    temp = numbers[j];
                    numbers[j] = numbers[j + 1];
                    numbers[j + 1] = temp;

                    
                }
                j++;
                if (j == numbers.Length - 1)
                {
                    time_complexity++;
                    i++;
                    j = 0;
                }
            }
            time_complexity++;

            Console.WriteLine("\n");
            Console.WriteLine("Sorted array is-");
            for (i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + "\t");
            }
            Console.WriteLine("Time complexity is = " + time_complexity);
        }
    }
}
