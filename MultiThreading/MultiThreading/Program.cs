using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MultiThreading
{
    
    class Program
    {   
 
        static void Main(string[] args)
        {
            //
            int num1; int num2;
            //ThreadPool.SetMaxThreads(2,2);
            ThreadPool.GetAvailableThreads( out num1,out num2);
            ThreadPool.QueueUserWorkItem(new WaitCallback(function1));
            ThreadPool.QueueUserWorkItem(new WaitCallback(function1));
            ThreadPool.QueueUserWorkItem(new WaitCallback(function1));
            ThreadPool.QueueUserWorkItem(new WaitCallback(function1));
            ThreadPool.QueueUserWorkItem(new WaitCallback(function1));
            Console.WriteLine(num2);
            Parallel.Invoke(function3,function2);
            Program p1 = new Program();
            Thread myThread = new Thread(p1.divide);
           // Thread myThread1 = new Thread(function2);
           
        // Thread myThread2 = new Thread(function1);
           // myThread1.IsBackground = true;
            myThread.Start();
            p1.divide();
            // myThread1.Start();
            // myThread2.Start();

            Console.ReadLine();
        }
        static void function1(object a)
        {
             
                Console.WriteLine("Hello from thread 1");
           // Console.ReadLine();
             
        }
        static void function2()
        {

            Console.WriteLine("Hello from thread 2");
            Console.ReadLine();

        }
        static void function3()
        {

            Console.WriteLine("Hello from thread 3");
            Console.ReadLine();

        }
        public void divide()
        {
           
            Random rnd = new Random();
           // Monitor.Enter(this);
                for (int i = 1; i < 100000; i++)
                {
                int num1 =rnd.Next(1,5);
                int num2 = rnd.Next(1, 5);
                int result = num1 /num2;
               num1 = 0;
                num2 = 0;
                }
          //  Monitor.Exit(this);
            
           
        }
    }
}
