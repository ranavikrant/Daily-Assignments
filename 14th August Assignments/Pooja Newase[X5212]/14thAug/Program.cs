using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14thAug
{
    class Program
    {
        static void Main(string[] args)
        {
            bubbleSort bubbleSortObj = new bubbleSort();
         
            bubbleSortObj.sortArray2();
            Console.Write("\n\n");

            setQuestionPaper sq = new setQuestionPaper();
            sq.setPaper();
            Console.ReadLine();
        }
    }
}
