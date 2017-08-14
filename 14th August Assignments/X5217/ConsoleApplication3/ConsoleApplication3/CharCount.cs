using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class CharCount
    {

        public void count()
        {

            String str = "hhaahhhr";
            char[] c = str.ToCharArray();
            int loopcount = 0;
            int count = 0;
            var watch = System.Diagnostics.Stopwatch.StartNew();
            for (int i = 0; i < c.Length; i++)
            {
                //System.out.println(c[i]+" "+i);
                bool flag = true;
                for (int k = 0; k < i; k++)
                {
                    if (c[i] == (str.ElementAt(k)))
                        flag = false;
                }
                if (flag)
                {
                    for (int j = 0; j < str.Length; j++)
                    {
                        if (c[i] == str.ElementAt(j))
                            count = count + 1;
                    }
                    Console.WriteLine(c[i] + " " + " " + (count));
                    count = 0;
                    loopcount++;
                }
            }
            watch.Stop();

            Console.WriteLine("\n Time : " + watch.Elapsed);
            Console.ReadLine();
        }



        public static SortedDictionary<char, ulong> Count(string stringToCount)
        {
            SortedDictionary<char, ulong> characterCount = new SortedDictionary<char, ulong>();
            var watch = System.Diagnostics.Stopwatch.StartNew();
            foreach (var character in stringToCount)
            {
                if (!characterCount.ContainsKey(character))
                {
                    characterCount.Add(character, 1);
                }
                else
                {
                    characterCount[character]++;
                }
            }
            watch.Stop();

            Console.WriteLine("\n Time : " + watch.Elapsed);

            return characterCount;
        }
    }
}
    

    

