using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1408
{
    class BubbleSort1Loop
    {
        public void SortingUsing1ForLoop()
        {
            List<int> elementList = new List<int>();
            int flag = 0;
            do
            {
                Console.WriteLine("Enter\n1. For Inputing Element\n0. For Exiting Input");
                int decisionOfData = Convert.ToInt32(Console.ReadLine());
                if (decisionOfData == 1)
                {
                    Console.WriteLine("Enter Data:");
                    int inputData = Convert.ToInt32(Console.ReadLine());
                    elementList.Add(inputData);
                }
                else if (decisionOfData == 0)
                    flag = 1;
                else
                    Console.WriteLine("You Entered wrong Command!!");
            } while (flag != 1);
            var watch = System.Diagnostics.Stopwatch.StartNew();
            for (int i = 1; i < elementList.Count; i++)
            {
                if (elementList[i] < elementList[i - 1])
                {
                    elementList[i] = elementList[i] + elementList[i - 1];
                    elementList[i - 1] = elementList[i] - elementList[i - 1];
                    elementList[i] = elementList[i] - elementList[i - 1];
                    i = 0;
                }
            }
            Console.WriteLine($"Time For Sorting is {watch.Elapsed}");
            watch.Stop();
            Console.WriteLine("Sorted List is:");
            for (int i = 0; i < elementList.Count; i++)
            {
                Console.WriteLine($"{elementList[i]}");
            }
        }
    }
}
