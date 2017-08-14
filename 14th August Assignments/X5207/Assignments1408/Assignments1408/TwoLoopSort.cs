using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments1408
{
    class TwoLoopSort
    {
        int i,temp, j;

        public void sort(int[] array, int array_length)
        {
            for (i = 0; i < array_length; i++)
            {
                for(j=1;j<array_length;j++)
                {
                    if (array[i] < array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }

                }

            }
            display(array);


        }

        public void display(int[] sorted_array)
        {
            foreach (int i in sorted_array)
                Console.Write(i);

        }


    }
}
