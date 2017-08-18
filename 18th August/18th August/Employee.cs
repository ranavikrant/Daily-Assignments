using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18th_August
{
    class Employee:IComparable<Employee>
    {
        public int id { get; set; }
        public string name { get; set; }
        public string department { get; set; }
        public int salary;
        public  int  CompareTo(Employee emp)
        {
            if (this.name.CompareTo(emp.name)>0)
            {
                return 1;
            }
            else return 0;
        }

       
    }
}
