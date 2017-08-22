using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

using System.Threading.Tasks;

namespace MemoryManagement
{
    class garbageCollection:IDisposable
    {
       // FileStream fs = new FileStream(@"d:\rana.txt", FileMode.Create);
        StreamWriter writer = new StreamWriter(@"d:\rana.txt");
        

       // StreamReader sr=new StreamReader(@"d:\rana.txt")

        public void Dispose()
        {
            Dispose(true);
        }

        public void Dispose(bool val)
        {
            if(val)
            {
                GC.SuppressFinalize(this);
            }
        }
    }
}
