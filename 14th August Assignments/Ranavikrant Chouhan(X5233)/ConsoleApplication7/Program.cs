using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Enter the length of array to be sorted");
            //int length=Convert.ToInt16( Console.ReadLine());
            //int[] arr =new int[length];
            //Console.WriteLine("Enter the elements");
            //for (int i = 0; i < length; i++)
            //{
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //BubbleSort b = new BubbleSort();

            //b.bubbleSort(arr);
            //b.normal(arr);

            //for (int i = 0; i < arr.Length; i++)
            //{               
            //   Console.WriteLine(arr[i]);
            //}


            Console.WriteLine("Enter the string");
            string s = Console.ReadLine();
            CountDuplicate c = new CountDuplicate();
            c.count(s);

            //QuestionSet q = new QuestionSet();
            //q.generate();
            
            

            Console.ReadLine();

        }
    }
}
