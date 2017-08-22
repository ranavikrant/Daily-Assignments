using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    public class MyException:Exception
    {
        public string method;
        public MyException(string message,string method):base(message)
        {
            this.method = method;
        }

    }
}
