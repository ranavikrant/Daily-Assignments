using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConQuestionPaper
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter No of Sets: ");
            int sets = int.Parse(Console.ReadLine());

            int[] noOfQuestions = new int[sets];
            int[] questionNo = new int[sets];            

            for(int i = 0; i < sets; i++)
            {
                Console.WriteLine("Enter No of Questions in Set {0}: ", Convert.ToChar(i + 65));
                noOfQuestions[i] = int.Parse(Console.ReadLine());
            }

            QuestionPaper questionPaper = new QuestionPaper();
            var watch = System.Diagnostics.Stopwatch.StartNew();
            char[] paper = questionPaper.SetQuestionPaper(noOfQuestions);
            watch.Stop();

            foreach (var que in paper)
            {
                questionNo[que - 65] += 1;
                Console.WriteLine(que + "" + questionNo[que - 65]);
            }

            Console.WriteLine("Time Required: {0}", watch.Elapsed);

            Console.Read();
        }
    }

    public class QuestionPaper
    {
        public char[] SetQuestionPaper(int[] noOfQuestions)
        {            
            int questions = 0, max, max2, i = 0;
            questions = noOfQuestions.Sum();
            
            char[] paper = new char[questions];

            do
            {
                max = Array.FindIndex(noOfQuestions, c => c == noOfQuestions.Max());
                noOfQuestions[max] -= 1;
                paper[i] = Convert.ToChar(max + 65);
                i++;

                max2 = 0;
                int idx = 0;       
                for (int j = 0; j < noOfQuestions.Length; j++)
                {
                    if(noOfQuestions[j] > max2 && j != max)
                    {
                        max2 = noOfQuestions[j];
                        idx = j;
                    }
                }

                noOfQuestions[idx] -= 1;
                paper[i] = Convert.ToChar(idx + 65);
                i++;               


            } while (i < questions - 1);

            return paper;
        }
    }
}
