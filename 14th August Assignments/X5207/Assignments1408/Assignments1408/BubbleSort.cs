using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments1408
{
    class BubbleSort
    {
        int i = 0,temp;
        

        public void bubble_sort(int[] array,int array_length)
        {
            for(i=1;i<=array_length-1;i++)
            {
                if (array[i] < array[i - 1])
                {
                    temp = array[i];
                    array[i] = array[i - 1];
                    array[i - 1] = temp;
                  
                   i = 0;
                }
                
               
               
            }

            

           
        }

        public void display(int[] sorted_array)
        {
            foreach (int i in sorted_array)
                Console.Write(i);
            
        }

    }
}
