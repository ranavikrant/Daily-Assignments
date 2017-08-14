using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_1408
{
    class Program
    {
        static void Main(string[] args)
        {
            ///<Single_loop_implemetation>
            //Bubble_sort_one_loop obj1 = new Bubble_sort_one_loop();
            //obj1.sort();

            ///<Double_loop_implementation>
            //Bubble_sort_two_loops obj2 = new Bubble_sort_two_loops();
            //obj2.sort();

            ///<Duplicate_charactes_string_implementation>
            Duplicate_characters_in_string obj = new Duplicate_characters_in_string();
            Console.WriteLine("Enter String:");
            string input = Console.ReadLine();
            obj.PrintDuplicateCharacters(input);
        }
    }
}
