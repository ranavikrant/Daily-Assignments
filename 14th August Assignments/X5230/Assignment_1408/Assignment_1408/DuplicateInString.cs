using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1408
{
    class DuplicateInString
    {
        public void FindingDuplicate()
        {
            Console.WriteLine("Input the string");
            string inputString = Convert.ToString(Console.ReadLine());
            StringBuilder outputString = new StringBuilder();
            string distinctString = "";
            var watch = System.Diagnostics.Stopwatch.StartNew();
            //var distinctWords = inputString.ToLower().Distinct();            
            foreach (char character in inputString)
            {
                //if (inputString.ToLower().Count(p => p == character && p != ' ') > 1)
                //{
                //    outputString.Append(character);
                //}
                if (!char.IsWhiteSpace(character))
                {
                    if (!(distinctString.ToLower().Contains(character)))
                    {
                        distinctString += character;
                    }
                    else
                    {
                        if (!(outputString.ToString().ToLower().Contains(character)))
                        {
                            outputString.Append(character);
                        }
                    }
                }
            }
            watch.Stop();
            Console.WriteLine($"Time For Removal is {watch.Elapsed}");
            Console.WriteLine($"Repeated Words are: {outputString}");
        }
    }
}
