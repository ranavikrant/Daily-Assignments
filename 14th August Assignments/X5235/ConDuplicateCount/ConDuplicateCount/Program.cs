using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConDuplicateCount
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] duplicateChars;
            Console.WriteLine("Enter The Statement:");
            string str = Console.ReadLine();
            
            Duplicates duplicates = new Duplicates();

            var watch = System.Diagnostics.Stopwatch.StartNew();
            duplicateChars = duplicates.FindDuplicates(str);
            watch.Stop();

            for (int i = 0; i < 26; i++)
            {
                if(duplicateChars[i] > 1)
                    Console.WriteLine("{0} : {1}", Convert.ToChar(i + 97), duplicateChars[i]);
            }

            Console.WriteLine("Time Required: {0}", watch.Elapsed);

            Console.Read();
        }
    }

    public class Duplicates
    {
        int[] arr = new int[26];

        public int[] FindDuplicates(string statement)
        {
            foreach (char ch in statement.ToLower())
            {
                // ASCII of a is 97 and z is 122
                if(97 <= ch && ch < 123)
                {
                    arr[ch - 97] += 1;
                }
            }
            return arr;
        }

    }
}
