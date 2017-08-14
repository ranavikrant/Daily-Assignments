using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assignment_5
{
    class DuplicateChar
    {
        Stopwatch stopWatch = new Stopwatch();
        public void ShowDuplicateCharactersInString()
        {
            /*
             Websites Referred :  https://stackoverflow.com/questions/4558754/define-what-is-a-hashset ; 
                                  https://msdn.microsoft.com/en-us/library/bb359438(v=vs.110).aspx ; 
                                  https://stackoverflow.com/questions/1343934/fastest-way-to-implement-duplicate-character-removal-in-string-c 
            */
            Console.Write("Enter the String : ");
            try
            {
                string InputString = Console.ReadLine();
                InputString = InputString.ToLower();
                InputString = Regex.Replace(InputString, @"\s", "");
                var HashSet1 = new HashSet<char>();
                var HashSet2 = new HashSet<char>();

                stopWatch.Start();
                foreach (var c in InputString)
                {
                    if (!HashSet1.Add(c))
                    {
                        HashSet2.Add(c);
                    }
                }
                HashSet1.UnionWith(HashSet2);
                char[] charArray = new char[HashSet1.Count];
                HashSet2.CopyTo(charArray);
                string DuplicateCharacters = new string(charArray);
                stopWatch.Stop();

                Console.WriteLine("Duplicate Characters : {0}", DuplicateCharacters);
                Console.WriteLine("Time Taken : {0}", stopWatch.Elapsed);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
