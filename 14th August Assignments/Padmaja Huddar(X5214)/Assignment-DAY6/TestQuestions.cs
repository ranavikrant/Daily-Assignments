using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_DAY6
{
    class TestQuestions
    {
        public void GenerateQuestions()
        {
            string[] A = { "A1", "A2", "A3", "A4", "A5", "A6", "A7", "A8", "A9", "A10" };
            string[] B = { "B1", "B2", "B3", "B4", "B5", "B6", "B7", "B8", "B9", "B10" };
            string[] C = { "C1", "C2", "C3", "C4", "C5" };
            string[] D = { "D1", "D2" };
            int max = A.Length;
            string[] insert = new string[27];
            insert = A;
            string[] str = new string[27];
            int question = 27,i,j;
            while (true)
            {
                if (B.Length > max)
                {
                    insert = B;
                    max = B.Length;
                }
                else
                   if (C.Length > max)
                {
                    insert = C;
                    max = C.Length;
                }
                else
                {
                    insert = D;
                    max = D.Length;
                }
                for (i = 0; i < max;)
                {
                    for(j=0;  j<27; j++)
                    {
                        str[j] = insert[i];
                        i++;
                        j++;
                    }
                }
                foreach(var s in str)
                {
                    Console.Write(s);
                }
                Console.Read();
            }
        }
    }
}
