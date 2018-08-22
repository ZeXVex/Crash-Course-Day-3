using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    class Program
    {
        public static bool Cehkpr(int num)
        {
            for (int i = 2; i < num; i++)
                if (num % i == 0)
                    return false;
            return true;
        }

            static void Main(string[] args)
            {
                int num;
                Console.WriteLine("To check a number is prime or not: ");
                Console.WriteLine("--------------------------------------------------");
                Console.Write("Input a number: ");
                num = Convert.ToInt32(Console.ReadLine());

                if (Cehkpr(num))
                    Console.WriteLine(num + " is a prime number");
                else
                    Console.WriteLine(num + " is not a prime number");

            Console.ReadLine();
            }
    }
}