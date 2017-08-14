using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_august_assignments
{
    class QuestionPaper
    {
        public int findLargestQuestionBank(int[] questionBankArray)
        {
            int numberOfQuestionBanks = questionBankArray.Length;
            int largestQuestionBank = -999;
            int indexOfLargestQuestionBank = 0;

            for(int i = 0 ;i < numberOfQuestionBanks ; i++)
            {
                if(largestQuestionBank < questionBankArray[i])
                {
                    largestQuestionBank = questionBankArray[i];
                    indexOfLargestQuestionBank = i;
                }
            }
            return indexOfLargestQuestionBank;
        }
        public void inputData()
        {
            Console.WriteLine("Enter number of question banks :");
            int numberOfQuestionBanks = Convert.ToInt32(Console.ReadLine());

            int[] questionBankArray = new int[numberOfQuestionBanks];

            Console.WriteLine("Enter count of questions in each question bank!");

            int sum = 0;
            for(int i = 0; i< numberOfQuestionBanks; i++)
            {
                questionBankArray[i] = Convert.ToInt32(Console.ReadLine());
                sum += questionBankArray[i];
            }
            StringBuilder finalQuestionPaper = new StringBuilder();

            int LargestQuestionBank = findLargestQuestionBank(questionBankArray);

            //finalQuestionPaper.Append("");

            Console.WriteLine("cqb: "+ (Convert.ToChar(65 + LargestQuestionBank))+""+ questionBankArray[LargestQuestionBank]);

            int currentQuestionBank = LargestQuestionBank;
            questionBankArray[currentQuestionBank]--; 

            Console.ReadLine();

            for (int i = 0 ; i < sum ; i++)
            {
                LargestQuestionBank = findLargestQuestionBank(questionBankArray);

                if ((LargestQuestionBank != currentQuestionBank) && (questionBankArray[LargestQuestionBank]>0))
                {
                    currentQuestionBank = LargestQuestionBank;
                    Console.WriteLine(Convert.ToChar(65 + LargestQuestionBank)+""+questionBankArray[currentQuestionBank]);
                    questionBankArray[currentQuestionBank]--;
                }
                else
                {
                    //if((questionBankArray[currentQuestionBank] > 0))
                    LargestQuestionBank = questionBankArray.Where((item,index) => index != LargestQuestionBank).Max();
                    //if ((LargestQuestionBank-1 != currentQuestionBank) && (questionBankArray[LargestQuestionBank-1] > 0))
                    //{
                        currentQuestionBank = LargestQuestionBank-1;
                        Console.WriteLine(Convert.ToChar(65 + LargestQuestionBank - 1) + "" + questionBankArray[currentQuestionBank]);
                        questionBankArray[currentQuestionBank]--;
                    //}
                    /*LargestQuestionBank = currentQuestionBank;
                    Console.WriteLine(Convert.ToChar(65 + currentQuestionBank) + "" + questionBankArray[currentQuestionBank-1]);
                    questionBankArray[currentQuestionBank-1]--;
                    Console.ReadLine();*/
                }
            }
            Console.ReadLine();
        }
    }
}
