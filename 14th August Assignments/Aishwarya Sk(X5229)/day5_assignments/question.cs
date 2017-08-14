using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5_assignments
{
    class Question
    {
        public void questions()
        {
           
            Console.WriteLine("enter the number of question banks");
            int que_bank = Convert.ToInt32(Console.Read());
            int[] question_set = new int[que_bank];
            Console.WriteLine("enter number of questions in each set");
            for(int i=0;i<=que_bank;i++)
            {
                question_set[i] = Convert.ToInt32(Console.Read());
            }
            Console.WriteLine("ghsahs");

        }
        
    }
}
