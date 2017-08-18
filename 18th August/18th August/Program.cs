using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _18th_August
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> empList = new List<Employee>();
            Employee e = new Employee();
            e.id = 1;
            e.name = "raven";
            e.department = "Mind Control";
            empList.Add(e);
            empList.Remove(e);
            empList.Add(e);
            empList.Where(e1 => e1.id == 1).First().name = "Kraven";

           // Console.WriteLine("Please enter the mobile number");
           // string mno = Console.ReadLine();
            
           // Regex MnoExpr = new Regex(@"^\d{3}-\d{4}$");
           //if( !MnoExpr.IsMatch(mno))
           // {
           //     Console.WriteLine("Wrong input");
           // }

           // Console.WriteLine("Enter a string");
           // string str = Console.ReadLine();
           // Regex SpaceExpr = new Regex("\\s+");
           // string space = " ";
           // Console.WriteLine(SpaceExpr.Replace(str,space));

            MyStringBuilder ms = new MyStringBuilder("I am batman");
            ms.append("fan");
            ms.append("can");
            ms.print();
            Console.WriteLine();

            Employee e11 = new Employee();
            Employee e22 = new Employee();
            Employee e33 = new Employee();
            e11.salary = 1000;
            e22.salary = 2000;
            e11.id = 4;
            e11.name = "maven";
            e11.department = "self Control";
            e33.name = "Darkseid";
            e22.id = 3;
            e22.name = "saven";
            e22.department = " Control";
            List<Employee> Elist = new List<Employee>();
            Elist.Add(e22);
            Elist.Add(e11);
            Elist.Add(e33);
            if ((Elist[0].CompareTo(Elist[1]) == 1))
            { Console.WriteLine("First salary>second"); }
            else
                Console.WriteLine("Second salary>First");


            Elist.Sort(); //Sort on Employee name
            Console.WriteLine("Sorted on name");
            foreach (var item in Elist)
            {
                
                Console.WriteLine(item.name);
            }

            List<Employee> sortedSalary = Elist.OrderBy(d => d.salary).ToList();
            Console.WriteLine("Sorted on Salary");
            foreach (var item in sortedSalary)
            {
                
                Console.WriteLine(item.salary);
            }

            List<Employee> sortedId = Elist.OrderBy(d => d.id).ToList();
            Console.WriteLine("Sorted on ID");
            foreach (var item in sortedId)
            {
                
                Console.WriteLine(item.id);
            }
            Console.ReadLine();
        }
    }
}
