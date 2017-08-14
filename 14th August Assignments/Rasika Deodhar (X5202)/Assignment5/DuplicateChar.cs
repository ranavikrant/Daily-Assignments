using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assignment5
{
    class DuplicateChar
    {
        public void duplicateChars(string str)
        {
            string str1 = "", duplicate = "";
            
            for (int i = 0; i < str.Length; i++)
            {
                if (!str1.Contains(str[i]))
                {
                    str1 = str1 + str[i];
                }
                else
                {
                    duplicate = duplicate + str[i];
                }
            }

            Console.WriteLine("String = " + str);
            Console.WriteLine("Duplicate = " + duplicate);

            int count = 0;
            for (int i = 0; i < duplicate.Length-1; i++)
            {
                if(duplicate[i].Equals(duplicate[i+1]))
                {
                    count++;
                    //j++;
                }count++;
                Console.WriteLine("Character " + duplicate[i] + " appears " + (count+1) + " times.");
                count=0;
            }
        }
    }
}
