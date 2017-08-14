using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    class Program3
    {
        static void Main(string[] args)
        {

           
            Stopwatch stopwatch = Stopwatch.StartNew();
            var chars = "ABCD";
            var numbers = "0123456789";
            var stringChars = new char[8];
            var random = new Random();

            

           
            for (int i = 0; i < 10; i++)
            {
                for (int j= 0; j < 1; j++)
                {
                    stringChars[j] = chars[random.Next(chars.Length)];
                }
                for (int k = 1; k < 2; k++)
                {
                    stringChars[k] = numbers[random.Next(numbers.Length)];
                }
                var finalString = new String(stringChars);
                Console.WriteLine(finalString);
            }
            

            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);
            Console.ReadLine();
        }
        
    }
}
