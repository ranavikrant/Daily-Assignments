using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class BubbleSort
    {
        int[] numbers = { 20, 15, 10, 2, 3, 5, 1, 4, 6, 9 };
        int[] A = { 20, 15, 10, 2, 3, 5, 1, 4, 6, 9 };
        int temp;
        
        public void sort()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            for (int row=0;row<numbers.Length;row++)
            {
                bool flag = false;
                for (int col=0;col<(numbers.Length-1-row);col++)
                {
                    if(numbers[col]>numbers[col+1])
                    {
                        flag = true;
                        temp = numbers[col+1];
                        numbers[col+1] = numbers[col];
                        numbers[col] = temp;
                    }
                }

                if (!flag)
                {
                    break;
                }
            }
            watch.Stop();
            Console.WriteLine("Sorted list :");

            for (int i = 0; i < numbers.Length; i++)
            {

                Console.Write("\t"+numbers[i]);
            }

            
            Console.WriteLine("\n Time : "+watch.Elapsed);
           
        }

        public void sort2()
        {
            
            int j = 0;
            int prevI = 0;
            var watch1 = System.Diagnostics.Stopwatch.StartNew();
            for (int i = 0; i < (numbers.Length - 1); i++)
            {
                j++;
                if (j < numbers.Length)
                {
                    i = prevI;
                }
                else
                {
                    j = i + 1;
                }

                if (numbers[i] > numbers[j])
                {
                    int temp = numbers[i];
                    numbers[i] = numbers[j];
                    numbers[j] = temp;
                }
                prevI = i;

            }
            watch1.Stop();
            Console.WriteLine("Sorted list :");

            for (int i = 0; i < numbers.Length; i++)
            {

                Console.Write("\t" + numbers[i]);
            }

            
            Console.WriteLine("\n Time : " + watch1.Elapsed);
            
        }

        public void sort3()
        {
            
            int n = 10;
            var watch1 = System.Diagnostics.Stopwatch.StartNew();
            do
            {    //This variable is used to store the  
                 //position of the last swap  
                int sw = 0;

                //Loop through all elements in the list  
                for (int i = 0; i < n - 1; i++)
                {
                    //If the current pair of elements is  
                    //not in order then swap them and update  
                    //the position of the swap  
                    if (A[i] > A[i + 1])
                    {
                        //Swap  
                        int temp = A[i];
                        A[i] = A[i + 1];
                        A[i + 1] = temp;

                        //Save swap position  
                        sw = i + 1;
                    }
                }

                //We do not need to visit all elements  
                //we only need to go as far as the last swap  
                //so we update (n)  
                n = sw;
            }

            //Once n = 1 then the whole list is sorted  
            while (n > 1);
            watch1.Stop();

            Console.WriteLine("Sorted list :");

            for (int i = 0; i < A.Length; i++)
            {

                Console.Write("\t" + A[i]);
            }
            Console.WriteLine("\n Time : " + watch1.Elapsed);
            Console.ReadLine();
        }
        
    }
}
