using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MultiThreading
{
    class ParallelClass
    {
        public void parallelFor()
        {
            Parallel.For(0,1000000,x=>function1());
            
            //    int j = 0;
            
            
        }
        static void function1()
        {
            int i = 0;
        }
    }
}
