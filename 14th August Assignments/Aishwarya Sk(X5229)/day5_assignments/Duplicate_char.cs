using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5_assignments
{
    class Duplicate_char
    {
        public void duplicate_char(string str)
        {
            // char[] result = new char[10];
            string s = "";
            string dup = "";
            char[] str1 = str.ToCharArray();
            Console.WriteLine(str1);
            Stopwatch stopwatch = Stopwatch.StartNew();
            for (int i = 0; i <= str1.Length - 1; i++)
            {
                if (!(s.Contains(str1[i]))) 
                {
                    s = s + str1[i];
                }
                else
                {
                    dup = dup + str1[i];
                  
                }
                
                }
            stopwatch.Stop();
            Console.WriteLine("duplicate chars are"+""+dup);
            Console.WriteLine("elapsed time "+stopwatch.Elapsed );
        }
        }
    
}
