using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace ConsoleApplication7
{
    class CountDuplicate
    {
        public void count(string test)
        {
            Stopwatch timer = Stopwatch.StartNew();
           
            int[] arr = new int[26];
            string test1 = test.ToLower();
            char[] letters=test1.ToCharArray();
            for (int i = 0; i < letters.Length; i++)
            {
                if ((int)letters[i] > 96 && (int)letters[i] < 123)
                {
                    int x = (int)letters[i];
                    x = x - 97;
                    arr[x] = arr[x] + 1;
                }
            }
            timer.Stop();
            Console.WriteLine("Time Taken:{0}", timer.Elapsed.TotalMilliseconds);
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i]>1)
                {
                    int x = arr[i];
                    char y = (char)(i + 97);
                    Console.WriteLine("Character {0} repeated {1} times", y, arr[i]);
                }
            }
            
            // Console.WriteLine();
        }
    }
}
