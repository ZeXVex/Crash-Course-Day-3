using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    class Program
    {
        public static int Fibo(int nno)
        {
            int num1 = 0;
            int num2 = 1;

            for (int i = 0; i < nno; i++)
            {
                int temp = num1;
                num1 = num2;
                num2 = temp + num2;
            }
            return num1;
        }

        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Display the n number Fibonacci series");
            Console.WriteLine("--------------------------------------------------");
            Console.Write("Input number: ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.Write("The Fibonacci series of " + num + " numbers is: ");
            for (int i = 0; i < num; i++)
                Console.Write(Fibo(i) + " ");

            Console.ReadLine();
        }
    }
}
