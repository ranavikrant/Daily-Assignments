using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1408
{
    class Program
    {
        static void Main(string[] args)
        {
            //BubbleSort2Loops sortingUsing2Loops = new BubbleSort2Loops();
            //sortingUsing2Loops.SortingUsing2ForLoop();
            //BubbleSort1Loop sortingUsing1Loop = new BubbleSort1Loop();
            //sortingUsing1Loop.SortingUsing1ForLoop();
            //DuplicateInString duplicateRomoval = new DuplicateInString();
            //duplicateRomoval.FindingDuplicate();
            QuestionPaper questionPapers = new QuestionPaper();
            questionPapers.CreaterQuestionPaper();
            Console.ReadLine();
        }
    }
}
