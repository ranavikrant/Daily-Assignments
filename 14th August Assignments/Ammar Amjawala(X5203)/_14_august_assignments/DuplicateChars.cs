using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_august_assignments
{
    class DuplicateChars
    {
        public void duplicates()
        {
            Console.WriteLine("Enter a string!");
            string teststring = Console.ReadLine();

            StringBuilder duplicateCharactersString = new StringBuilder();
            String visitorsString="";

            Stopwatch s = new Stopwatch();
            s.Start();
            foreach (char c in teststring)
            {
                if (!char.IsWhiteSpace(c))
                {
                    if (!(visitorsString.Contains(c)))
                    {
                        visitorsString += c;
                    }
                    else
                    {
                        if (!duplicateCharactersString.ToString().Contains(c))
                        {
                            duplicateCharactersString.Append(c);
                        }
                    }
                }
            }
            s.Stop();
            Console.WriteLine("Duplicate Characters are: "+duplicateCharactersString);
            Console.WriteLine("Elapsed time: "+s.Elapsed);
            Console.ReadLine();
        }
    }
}
