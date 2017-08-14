using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = new int[10];
            //Console.WriteLine("Enter total count");
            //int count = Int32.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the numbers");
            //for (int i = 0; i < count; i++)
            //{
            //    numbers[i] = Int32.Parse(Console.ReadLine());
            //}
            //BubbleSort sortobj = new BubbleSort();
            //var watchTwoLoops = System.Diagnostics.Stopwatch.StartNew();
            //sortobj.Sort(numbers, count);
            //watchTwoLoops.Stop();
            //var timetwoloops = watchTwoLoops.ElapsedMilliseconds;
            //Console.WriteLine(timetwoloops);


            //var watchoneLoop = System.Diagnostics.Stopwatch.StartNew();
            //sortobj.SortOneLoop(numbers, count);
            //watchoneLoop.Stop();
            //var timeOneLoop = watchoneLoop.ElapsedMilliseconds;
            //Console.WriteLine(timeOneLoop);

            Console.WriteLine("Enter a string");
            string str = Console.ReadLine(); ;
            Duplicate dup = new Duplicate();
            var watchdup = System.Diagnostics.Stopwatch.StartNew();
            dup.getduplicatechars(str);
            watchdup.Stop();
            var timedup = watchdup.ElapsedMilliseconds;
            Console.WriteLine("Time to find out duplication:" + timedup);

            //PaperSet p = new PaperSet();
            //p.find();
            Console.ReadLine();

        }
    }
}
