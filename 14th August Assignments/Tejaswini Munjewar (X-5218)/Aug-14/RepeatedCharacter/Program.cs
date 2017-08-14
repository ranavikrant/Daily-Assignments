using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatedCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            CharCount count = new CharCount();
            Console.WriteLine("Enter any string: ");
            string str = Console.ReadLine();
           
            var watch = System.Diagnostics.Stopwatch.StartNew();
            Console.WriteLine("Repeated character count: {0}", count.FindCount(str));
            watch.Stop();
            Console.WriteLine("Time Taken: {0}", watch.Elapsed);
            Console.Read();

        }
    }
}
