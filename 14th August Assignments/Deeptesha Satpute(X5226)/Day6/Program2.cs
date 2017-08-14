using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    class Program2
    {
        static void Main(string[] args)
        {
           // string test = "This is a test";
            
            string word = "Thisisateststatement";
            var distinctChars = word.Distinct();
            Stopwatch stopwatch = Stopwatch.StartNew();
            foreach (char c in distinctChars)
                if (word.Count(p => p == c) > 1)
                {
                    Console.WriteLine(c);
                }
            stopwatch.Stop();
           
            Console.WriteLine(stopwatch.Elapsed);
            Console.ReadLine();
        }
    }
}
