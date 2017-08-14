using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            BubbleSort bubleSort = new BubbleSort();                            //Question 1 : Bubble Sort
            bubleSort.InputForBubbleSort();
            */

            
            DuplicateChar duplicateChar = new DuplicateChar();                  //Question 2 : Duplicate Characters
            duplicateChar.ShowDuplicateCharactersInString();

            /*
            QuestionSet questionSet = new QuestionSet();                        //Question 3 : Printing Questions
            questionSet.PrintQuestions();                                           (Not Completed)
            */
            Console.ReadKey();
        }
    }
}
