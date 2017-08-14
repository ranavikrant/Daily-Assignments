using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bubble Sort

            //int n;
            //Console.WriteLine("Enter number of digits to enter-");
            //n = Convert.ToInt32(Console.ReadLine());
            //int[] numbers1 = new int[n];
            //int[] numbers2 = new int[n];
            //Console.WriteLine("Enter digits one by one-");
            //for (int i=0;i<n;i++)
            //{
            //    numbers1[i]=Convert.ToInt32(Console.ReadLine());
            //    numbers2[i] = numbers1[i];
            //}
            //Console.WriteLine("Entered numbers are -");
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write(numbers1[i] + "\t");
            //}
            //Console.WriteLine("\n");
            //BubbleSort objBubbleSort = new BubbleSort();

            //Console.WriteLine("Sorting using two loops-");
            //var watch2Loops = System.Diagnostics.Stopwatch.StartNew();
            //objBubbleSort.bubble_sort_TwoLoops(numbers1,0);
            //watch2Loops.Stop();
            //var time2Loops = watch2Loops.ElapsedMilliseconds;
            //Console.WriteLine("Time for 2 loops = " + time2Loops);
            //Console.WriteLine("\n");

            //Console.WriteLine("Sorting using one loop-");
            //var watch1Loop = System.Diagnostics.Stopwatch.StartNew();
            //objBubbleSort.bubble_sort_SingleLoop(numbers2,0);
            //watch1Loop.Stop();
            //var time1Loop = watch1Loop.ElapsedMilliseconds;
            //Console.WriteLine("Time for 1 loop= " + time1Loop);

            //Duplicate Chars
            //DuplicateChar objDuplicate = new DuplicateChar();
            //var watch = System.Diagnostics.Stopwatch.StartNew();
            //string str = "my name is RRR";
            //objDuplicate.duplicateChars(str);
            //watch.Stop();
            //var time = watch.ElapsedMilliseconds;
            //Console.WriteLine("Time = " + time);

            //Sets of Question Papers - Examination
            Examination ex = new Examination();
            Console.WriteLine("Enter number of sets = ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] ques = new int[n];
            Console.WriteLine("Enter the number of sets per questions-");
            for (int i = 0; i < ques.Length; i++)
            {
                ques[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Entered values -");
            for (int i = 0; i < ques.Length; i++)
            {
                Console.Write(ques[i] + "\t");
            }
            Console.WriteLine(" \n ");
            ex.Exam(ques);

            Console.ReadLine();
        }
    }
}
