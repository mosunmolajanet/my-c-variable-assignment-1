using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_c_variable_assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 4;
            double d = 4.0;
            string s = "Polyilaro ";
            Console.WriteLine("INPUT");
            Console.WriteLine("enter the value of the new integer");
            int second_int = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" enter the value of new double");
            double second_double = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("hello user complete your sentence: Polyilaro ........");
            string second_string = (Console.ReadLine());
            int a = i + second_int;
            double b = d + second_double;
            string c = s + second_string;
            //to print the output
            Console.WriteLine();
            Console.WriteLine("OUTPUT");
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.ReadLine();

        }
    }
}
