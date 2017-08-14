using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1408
{
    class QuestionPaper
    {
        public void CreaterQuestionPaper()
        {
            Console.WriteLine("Enter the set of Question Papers:");
            int[] questionsInEachSets=new int[10];
            int sum = 0;
            bool flag = true;
            char? currentSet=null;
            int sets = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= sets; i++)
            {
                Console.WriteLine($"Enter the number of Question Papers in set number {i}");
                questionsInEachSets[i] = Convert.ToInt32(Console.ReadLine());
                sum += questionsInEachSets[i];
            }
            foreach(int questionInASet in questionsInEachSets)
            {
                if (questionInASet > sum - questionInASet + 1)
                {
                    Console.WriteLine("It is not possible to create Question Paper");
                    flag = false;
                }
            }
            var watch = System.Diagnostics.Stopwatch.StartNew();
            int maximumInASet = questionsInEachSets.Max();
            int maximumIndex = questionsInEachSets.ToList().IndexOf(maximumInASet);            
            while (flag)
            {
                if (maximumInASet != 0)
                {
                    switch (maximumIndex)
                    {
                        case 1:
                            currentSet = 'A';
                            break;
                        case 2:
                            currentSet = 'B';
                            break;
                        case 3:
                            currentSet = 'C';
                            break;
                        case 4:
                            currentSet = 'D';
                            break;
                    }
                    Console.WriteLine($"{currentSet}{maximumInASet}");
                    questionsInEachSets[maximumIndex]--;
                    maximumInASet = questionsInEachSets.Where((number, index) => index != maximumIndex).Max();
                    maximumIndex = questionsInEachSets.ToList().IndexOf(maximumInASet);
                }
                else
                {
                    flag = false;
                }
            }
            Console.WriteLine($"Time For Sorting is {watch.Elapsed}");
            watch.Stop();
        }
    }
}
