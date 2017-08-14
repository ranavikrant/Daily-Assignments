using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class BubbleSort
    {
        public void Sort(int[] numb,int count)
        {
            int temp;
            for (int row = 0; row < count-1; row++)
            {
                for (int comp = 0; comp < count-1; comp++)
                {
                    if (numb[comp] > numb[comp + 1])
                    {
                        temp = numb[comp+1];
                        numb[comp+1] = numb[comp];
                        numb[comp] = temp;
                    }
                }

            }
            Console.WriteLine("The sorted array using two loops is");

            for (int itr = 0; itr < count; itr++)
            {
                Console.WriteLine(numb[itr]);
            }
            Console.ReadLine();
            
        }

        public void SortOneLoop(int[] num,int count)
        {

            int temp;
                for (int comp = 0; comp < count-1 ; comp++)
                {
                    if (num[comp] > num[comp + 1])
                    {
                        temp = num[comp + 1];
                        num[comp + 1] = num[comp];
                        num[comp] = temp;
                        comp = 0;

                    }
                }

            Console.WriteLine("The sorted array using one loop is");

            for (int itr = 0; itr < count; itr++)
            {
                Console.WriteLine(num[itr]);
            }
            Console.ReadLine();

        }
    }
}
