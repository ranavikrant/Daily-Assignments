using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5_assignments
{
    class Program
    {
        static void Main(string[] args)
        {
            BubbleSort p = new BubbleSort();
            // declaring array to store elements
            int n;
            Console.WriteLine("Enter no of elements you want to store in an array");
            n = Convert.ToInt32(Console.ReadLine()); // taking input from user
            int[] arr = new int[n];
            Console.WriteLine("Enter elements in an array");
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("entered array" + arr[i]);
            }
            p.bubblesort(arr, n);
            p.bubblesort_optimized(arr, n);
            Console.ReadLine();
            //Duplicate_char d = new Duplicate_char();
            //    Console.WriteLine("enter a string");
            //    string str = Console.ReadLine();
            //   d.duplicate_char(str);
            //  Console.ReadLine();

        }
    }
}
