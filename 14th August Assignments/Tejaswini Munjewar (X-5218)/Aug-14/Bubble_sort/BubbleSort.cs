using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aug_14
{
    class BubbleSort
    {
        public int[] SortOptimized(int[] numbers)
        {
            bool swapped = false;
            for (int i = 0, j = 1; i < numbers.Length - 1; j++)
            {
                if (numbers[i] > numbers[j])
                {
                    int tmp = numbers[i];
                    numbers[i] = numbers[j];
                    numbers[j] = tmp;
                    swapped = true;
                }

                if (j == numbers.Length - 1)
                {
                    i++;
                    j = i;
                    if (!swapped)
                    {
                        swapped = true;
                        break;
                    }
                }
            }
            return numbers;
        }




        public int[] SortNormal(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                bool swaped = false;
                for (int j = i; j < numbers.Length; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        int tmp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = tmp;
                        swaped = true;
                    }
                }
                if (!swaped)
                    break;
            }
            return numbers;
        }
    
    }
}
