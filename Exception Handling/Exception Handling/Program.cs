using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1=0, num2=0;

            Console.WriteLine("Enter two numbers");
            try
            {
                 num1 = Convert.ToInt32(Console.ReadLine());
                 num2 = Convert.ToInt32(Console.ReadLine());
            }
            catch(FormatException fe)
            {
                Console.WriteLine(fe.Message);
            }
            Console.WriteLine("Choose option \n1.Add\n2.Substact\n3.multiply\n4.Divide");
            MathLib m = new MathLib();
            string choice = Console.ReadLine();
            switch(choice)
            {
                case "1":try { Console.WriteLine("Addition is {0}", m.add(num1, num2)); }
                    catch(NullReferenceException ne)
                    {
                        Console.WriteLine(ne);
                    }
                    break;
                case "2":
                    Console.WriteLine("Substraction is {0}", m.sub(num1, num2));
                    break;
                case "3":
                    Console.WriteLine("Multiplication is {0}", m.multiply(num1, num2));
                    break;
                case "4":
                    Console.WriteLine("Division is {0}", m.div(num1, num2));
                    break;
                default:
                    Console.WriteLine("Enter a correct choice");
                    break;

            }
            Console.ReadLine();

        }
    }
}
