using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    class QuestionSet
    {
        public void PrintQuestions()
        {
            int i;
            Console.Write("Enter number of questions in Set A : ");
            int QuestionsInA = Convert.ToInt16(Console.ReadLine());
            Console.Write("Enter number of questions in Set B : ");
            int QuestionsInB = Convert.ToInt16(Console.ReadLine());
            Console.Write("Enter number of questions in Set C : ");
            int QuestionsInC = Convert.ToInt16(Console.ReadLine());
            Console.Write("Enter number of questions in Set D : ");
            int QuestionsInD = Convert.ToInt16(Console.ReadLine());
            int TotalQuestions = QuestionsInA + QuestionsInB + QuestionsInC + QuestionsInD;

            for (i = 0; i < TotalQuestions; i++)
            {
                int max = Math.Max(QuestionsInA,(Math.Max(QuestionsInB,(Math.Max(QuestionsInC,QuestionsInD)))));
                Console.WriteLine(max);

            }
        }
    }
}
