using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class Examination
    {
        public void Exam(int[] questions)
        {
            int max = 0,n;
            for (int i = 0; i < questions.Length; i++)
            {
                if(max<questions[i])
                {
                    max = questions[i];
                }
            }
            n = max;
            Console.WriteLine("Max = " + max);
            int[,] quest = new int[questions.Length,max];

            for (int i = 0; i < questions.Length; i++)
            {
                for (int j = 0; j < max; j++)
                {
                    quest[i,j] = 0;
                }
            }

            for (int i = 0; i < questions.Length; i++)
            {
                for (int j = 0; j < max; j++)
                {
                    Console.Write(quest[i,j] + "\t");
                }
                Console.WriteLine("\n");
            }
        }
    }
}
