using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    class MathLib
    {
        int result;
        public int add(int a , int b)
        {
            result = a + b;
            return result;
        }
        public int multiply(int a, int b)
        {
            try
            {
                if(b==0||a==0)
                { throw (new MyException("Zero multiplicand","Multiply method")); }
                result = a * b;
               
            }
            catch(MyException me)
            {
                Console.WriteLine(me);
                Console.WriteLine(me.method);
            }
            return result;
        }
        public int sub(int a, int b)
        {
            result = a - b;
            return result;
        }
        public int div(int a, int b)
        {
            try
            {
                result = a / b;
               
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
             return result; 
        }
    }
}
