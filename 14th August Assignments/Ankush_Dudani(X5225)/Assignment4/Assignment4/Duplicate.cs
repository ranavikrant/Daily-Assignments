using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Duplicate
    {
        public void getduplicatechars(string str)
        {
            
            string dupchar="";
            string str1 = "";
         
            for(int i=0;i<str.Length;i++)
            {
                if (!str1.Contains(str[i]))
                {
                    str1 = str1 + str[i];
                }
                else
                    dupchar = dupchar + str[i];
            }
            char[] ans = dupchar.Distinct().ToArray();
            Console.WriteLine(ans);
            //Console.WriteLine(dupchar);

        }
    }
}
