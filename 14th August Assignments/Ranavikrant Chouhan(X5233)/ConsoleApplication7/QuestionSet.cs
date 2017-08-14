using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    public class QuestionSet
    {
      public string[] A = { "A1", "A2", "A3", "A4" };
      public string[] B = { "B1", "B2", "B3", "B4" };
      public string[] C = { "C1", "C2", "C3", "C4" };
      public string[] D = { "D1", "D2", "D3", "D4" };

        public void generate()
        {
            string[] jointarr = new string[10];
            int k = 0;
            int count = 10;
            for (int i = 0; i < A.Length-1; i++)
            {
                for (int j = 0; j < B.Length-1; j++)
                {
                    string cc = jointarr.ToString();
                    char[] ch = cc.ToCharArray();
                    if(cc.Contains(A[i]) || cc.Contains(B[i]))
                    { continue; }
                    if (!cc.Contains(A[i]) || !cc.Contains(B[i]))
                        jointarr[k] = A[i] + " " + B[j];

                    k++;
                }
            }
            foreach(string i in jointarr)
            {
                Console.Write(i);
            }

        }
    }
}
