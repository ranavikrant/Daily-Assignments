using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            BubbleSort s = new BubbleSort();
            CharCount c = new CharCount();


            //the code that you want to measure comes here
            /*s.sort();
            Console.WriteLine("SORT 2");
            s.sort2();
            Console.WriteLine("SORT 3");
            s.sort3();

            string longText = "The quick brown";

            var count = CharCount.Count(longText);

            foreach (var character in count)
            {
                Console.WriteLine("{0} - {1}", character.Key, character.Value);
            }*/
            //c.count();
            RamdomQuestions r = new RamdomQuestions();
            r.setQuesPaper();
            Console.ReadLine();
        }
    }
}
