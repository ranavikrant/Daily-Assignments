using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryManagement
{
    class CustomException:Exception
    {

        public CustomException(string msg):base(msg)
        {

        }
    }

    public class Temprature
    {
        int temp = 0;
        public void show()
        {
            if(temp==0)
            {
                throw (new CustomException("Zero not allowed"));
            }
        }
    }
}
