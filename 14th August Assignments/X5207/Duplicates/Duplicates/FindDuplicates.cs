using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duplicates
{
    class StringDuplicate
    {
        
        String result = "";
       

        public void FindDuplicates(String sentence)
        {
            char[] repeated = sentence.ToCharArray();
            for (int i = 0; i < repeated.Count() - 1; i++)
            {
                for (int j = i + 1; j <= repeated.Count() - 1; j++)
                {


                    if (repeated[i] == repeated[j])
                    {
                        result += repeated[j];

                    }


                }
            }
            Console.Write(result);
        }

        
    }
}
