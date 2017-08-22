using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryManagement
{
    class ExceptionDivision
    {
        public void division(int n1,int n2)
        {
            int result=0;
            try
            {
                result = n1 / n2;
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Caught {0} exception",ex);
            }
            finally
            {
                Console.WriteLine("Division is:{0}",result);
            }
        }

    }
}
