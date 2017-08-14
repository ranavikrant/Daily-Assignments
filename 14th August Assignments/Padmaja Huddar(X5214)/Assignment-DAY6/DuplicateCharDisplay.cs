using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_DAY6
{
    class DuplicateCharDisplay
    {
        Stopwatch watch = new Stopwatch();
        public void CharDisplay(string senetnce)
        {

            watch.Start();
            string str = "";
            string duplicate = "";
            for(int i=0;i<senetnce.Length;i++)
            {
                if(!str.Contains(senetnce[i]))
                {
                    str = str + senetnce[i];
                }
                else
                {
                    if (!duplicate.Contains(senetnce[i]))
                    {
                        duplicate = duplicate + senetnce[i];
                    }
                }
            }
            watch.Stop();
            Console.WriteLine("Duplicate characters in the sentence are: ");
            foreach (char ch in duplicate)
            {
                Console.Write("{0}\t", ch);
            }
            Console.Write("Time:{0}ms", watch.Elapsed);
            Console.ReadLine();
        }
    }
}

