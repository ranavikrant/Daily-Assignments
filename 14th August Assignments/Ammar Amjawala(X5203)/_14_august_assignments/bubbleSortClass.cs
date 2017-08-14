using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_august_assignments
{
    class bubbleSortClass
    {
        int numberOfElements;

        public void acceptElements()
        {
            Console.WriteLine("Number of elements you want to sort?");

            numberOfElements = Convert.ToInt32(Console.ReadLine());

            int[] arrayOfElements = new Int32[numberOfElements];

            Console.WriteLine(string.Format("Enter {0} elements: ", numberOfElements));

            for (int i = 0; i < numberOfElements; i++)
            {
                arrayOfElements[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Before Sorting:");
            foreach (int a in arrayOfElements)
            {
                Console.WriteLine(a);
            }

            sort(arrayOfElements);
            optimisedSort(arrayOfElements);

        }
        public void optimisedSort(int[] arrayOfElements)
        {
            
            Stopwatch stopwatch = Stopwatch.StartNew();
   
            for (int i = 0; i < numberOfElements - 1; i++)
            {

                    if (arrayOfElements[i] > arrayOfElements[i+1])
                    {
                        int temp = arrayOfElements[i];
                        arrayOfElements[i] = arrayOfElements[i+1];
                        arrayOfElements[i+1] = temp;
                        i = 0;
                    }
            }
            stopwatch.Stop();
            Console.WriteLine("Optimized Sorting took " + stopwatch.Elapsed);
            Console.WriteLine("After Sorting:");
            foreach (int a in arrayOfElements)
            {
                Console.WriteLine(a);
            }
            Console.ReadLine();
        }

        public void sort(int[] arrayOfElements)
        {

            Stopwatch stopwatch = Stopwatch.StartNew(); 
              
            for (int i = 0;i < numberOfElements - 1;i++)
            {
                for(int j = 0; j < numberOfElements - i - 1 ; j++)
                {
                    if(arrayOfElements[j] > arrayOfElements[j+1])
                    {
                        //Swap
                        int temp = arrayOfElements[j];
                        arrayOfElements[j] = arrayOfElements[j+1];
                        arrayOfElements[j+1] = temp;
                    }
                }
            }
            stopwatch.Stop();

            Console.WriteLine("Normal Sorting took "+ stopwatch.Elapsed);
            Console.WriteLine("After Sorting:");

            foreach (int a in arrayOfElements)
            {
                Console.WriteLine(a);
            }

            Console.ReadLine();
        }
    }
}
