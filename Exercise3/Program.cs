using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
    {
        public static int add(int num1, int num2)
        {
            int total;
            total = num1 + num2;
            return total;
        }

        static void Main(string[] args)
        {
            int num1, num2;

            Console.WriteLine("Sum of 2 number");
            Console.Write("Write the first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Write the second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The sum of the numbers is: {0}", add(num1,num2));
            Console.ReadLine();
        }
    }
}
