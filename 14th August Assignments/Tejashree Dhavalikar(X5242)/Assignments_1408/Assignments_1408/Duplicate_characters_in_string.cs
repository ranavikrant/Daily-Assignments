using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace Assignments_1408
{
    class Duplicate_characters_in_string
    {
        Stopwatch stopwatch = Stopwatch.StartNew();
        public void PrintDuplicateCharacters(string InputString)
        {
            if (string.IsNullOrWhiteSpace(InputString))
            {
                Console.WriteLine("Input is not valid");
            }
            else
            {
                var dictionary = new Dictionary<char, int>();
                foreach (var character in InputString)
                {
                    if (Equals(character, ' '))
                    {
                        continue;
                    }

                    if (dictionary.ContainsKey(character))
                    {
                        dictionary[character]++;
                    }
                    else
                    {
                        dictionary.Add(character, 1);
                    }
                }

                bool characterFound = false;
                foreach (var character in dictionary)
                {
                    if (character.Value > 1)
                    {
                        Console.WriteLine(character.Key);
                        characterFound = true;
                    }
                }

                if (!characterFound)
                {
                   Console.WriteLine("No duplicate character found");
                }
            }
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);
            Console.ReadLine();
           
        }
        
    }
}
