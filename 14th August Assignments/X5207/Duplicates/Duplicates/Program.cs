using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Duplicates
{
    class Program
    {
        static void Main(string[] args)
        {
            String sentence  ;
            sentence = Console.ReadLine();
            
            Stopwatch timer = Stopwatch.StartNew();


            StringDuplicate string_duplicate_obj = new StringDuplicate();
            string_duplicate_obj.FindDuplicates(sentence);
            
            timer.Stop();
            Console.WriteLine("\nTime:{0}", timer.Elapsed);




            Console.ReadLine();
            



        }
    }
}
