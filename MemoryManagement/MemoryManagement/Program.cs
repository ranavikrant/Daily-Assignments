using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MemoryManagement
{
    class Program:IDisposable
    {
       
        static void Main(string[] args)
        {
            using (StreamWriter writer = new StreamWriter(@"d:\rana.txt"))
            {
                writer.WriteLine("I am vengence");
                writer.WriteLine("I am the night");
                writer.WriteLine("I am BATMAN!!!");
                writer.Close();
            }
            StreamReader reader = new StreamReader(@"d:\rana.txt");
            Console.WriteLine(reader.ReadToEnd());
            reader.Close();
            //if (writer != null)
            //{
            //    writer.Dispose();
            //}
            if (reader != null)
            {
                reader.Dispose();
            }

            ExceptionDivision e = new ExceptionDivision();
            e.division(2, 2);
            Temprature t = new Temprature();
            try
            {
                t.show();
            }
            catch(CustomException c)
            {
                Console.WriteLine("Exception {0} caught",c.Message);
            }
            Console.ReadLine();

        }
        public  void Dispose()
        {
            Console.WriteLine("Disposed");
            Dispose(true);
        }

        public  void Dispose(bool val)
        {
            if (val)
            {
                GC.SuppressFinalize(this);
            }
           
           
          
        }
    }
}
