using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18th_August
{
    public class MyStringBuilder
    {
        public char[] arr;
        //public char[] appendArr;

       public MyStringBuilder(string s)
        {
            arr = s.ToCharArray();
        }

        public void append(String s)
        {
            string s1 = "";
            string s2=new string(arr);
            s1 =  s2 +" "+ s ;
            arr = s1.ToCharArray();

        }
        public void print()
        {
            foreach (char item in arr)
            {
                Console.Write(item);
            }
        }

    }
}
