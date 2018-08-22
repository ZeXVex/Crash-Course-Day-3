using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    class Program
    {
        public static void Swapping(ref int num1, ref int num2)
        {
            int num;

            num = num1;
            num1 = num2;
            num2 = num;
        }


        static void Main(string[] args)
        {
            int num1, num2;

            Console.WriteLine("Swapping the first number with the second nuymber");
            Console.WriteLine("--------------------------------------------------");
            Console.Write("First number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Swapping(ref num1, ref num2);
            Console.WriteLine("Now the first number is: {0} and the second number is: {1}", num1, num2);
            Console.ReadLine();
        }
    }
}
