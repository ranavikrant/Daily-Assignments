using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duplicate_Letters
{
    class duplicateletters
    {
        public void duplicate_letters()
        {
            Console.WriteLine("Enter a string");
            string word = Console.ReadLine();

            StringBuilder duplicate_chars = new StringBuilder();
            String newString = "";
            foreach (char c in word)
            {
                if (!char.IsWhiteSpace(c))
                {
                    if (!(newString.Contains(c)))
                    {
                        newString += c;
                    }
                    else
                    {
                        if (!duplicate_chars.ToString().Contains(c))
                        {
                            duplicate_chars.Append(c);
                        }
                    }
                }
            }
            Console.WriteLine("Duplicate Characters are: " + duplicate_chars);
            Console.ReadLine();
        }
   }
}
