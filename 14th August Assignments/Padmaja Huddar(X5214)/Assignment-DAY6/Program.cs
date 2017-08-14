using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_DAY6
{
    class Program
    {
        static void Main(string[] args)
        {
            //----------QUESTION 1------------------
            Random r = new Random();
            try
            {
                int[] numbers = new int[10];
                for (int counter = 0; counter < 10; counter++)
                {
                    Console.Write("Enter the number:");
                    numbers[counter] = int.Parse(Console.ReadLine());
                    //numbers[counter] = r.Next(0,25000);
                }
                BubbleSort BubbleSortObj = new BubbleSort();
                BubbleSortObj.Sort(numbers);
                Console.Read();
            }
            catch (Exception ex)
            {
                Console.Write("Exception is: {0}", ex);
                Console.Read();
            }


            //----------------QUESTION 2---------------------
            try
            {
                Console.Write("Enter the string:");
                string sentence = Console.ReadLine();
                DuplicateCharDisplay obj = new DuplicateCharDisplay();
                obj.CharDisplay(sentence);
            }
            catch (Exception ex)
            {
                Console.Write("Exception is: {0}", ex);
                Console.Read();
            }


            //------------------QUESTION 3------------------------
            //TestQuestions test = new TestQuestions();
            //test.GenerateQuestions();
        }
    }
}
