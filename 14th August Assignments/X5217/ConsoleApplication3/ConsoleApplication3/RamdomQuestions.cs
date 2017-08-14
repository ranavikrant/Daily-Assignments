using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class RamdomQuestions
    {
        public void setQuesPaper()
        {
            string[] A = new string[] { "A1", "A2", "A3" };
            string[] B = { "B1", "B2", "B3", "B4", "B5", "B6" , "B7"};
            string[] C = new string[] { "C1", "C2" , "C3"};
            string[] D = new string[] { "D1" };
            string[] list = new string[10];
            string[] list1 = new string[10];
            string[] list2 = new string[10];

            int lenA = A.Length;
            int lenB = B.Length;
            int lenC = C.Length;
            int lenD = D.Length;
            Int64 max1,max2,max3,max4;
            int len = lenA + lenB + lenC + lenD;

            max1 = lenA;
            max2 = lenB;
            max3 = lenC;
            max4 = lenD;

            var watch = System.Diagnostics.Stopwatch.StartNew();
            for (int i=0,j=0;j<max1;i+=2,j++)
                {
                
                    list[i] = B[j];
                }
                
            for(int k=1,i=0;k<max1*2;k+=2,i++)
            {
                list[k] = A[i];
            }

            for (int i = 0, j = lenA; j < max1+max3; i += 2, j++)
            {

                list1[i] = B[j];
            }

            for (int k = 1, i = 0; k < max3*2; k += 2, i++)
            {
                list1[k] = C[i];
            }

            for (int i = 0, j = lenA+lenC; j < max1 + max3+ max4; i += 2, j++)
            {

                list2[i] = B[j];
            }

            for (int k = 1, i = 0; k < max4 * 2; k += 2, i++)
            {
                list2[k] = D[i];
            }
            watch.Stop();

            Console.WriteLine("\n Time : " + watch.Elapsed);
            var finalList = list.Concat(list1).Concat(list2);
            foreach (var item in finalList)
            {
                Console.Write( item+" ");
            }
            Console.ReadLine();

        }
    }
}
