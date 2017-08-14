using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class PaperSet
    {
        public void find()
        {
            Console.WriteLine("Enter number of question sets");
            int qsets = Int32.Parse(Console.ReadLine());
            int[] ques1=new int[qsets+1];
            
            for (int ques = 1; ques <=qsets; ques++)
            {
                Console.WriteLine("Enter number of question in Set:"+ques);
                ques1[ques] = Int32.Parse(Console.ReadLine());
            }

            int maxquesset = ques1.Max();
            

            Console.ReadLine();   
        }
    }
}
