using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    class Program
    {
        public static int PowerRaise(int num, int sqr)
        {
            int raise = 1;
            for (int i = 0; i < sqr; i++)
                raise = raise * num;

            return raise;
        }

        static void Main(string[] args)
        {
            int num1, sqr1;
            Console.WriteLine("Swapping the first number with the second nuymber");
            Console.WriteLine("--------------------------------------------------");
            Console.Write("Input number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input exponent: ");
            sqr1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Result {0}^{1} = {2}", num1, sqr1, PowerRaise(num1, sqr1));
            Console.ReadLine();
        }
    }
}
