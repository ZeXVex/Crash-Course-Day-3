using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        public static void welcome()
        {
            Console.WriteLine("Welcome Freinds");
        }

        public static void HaveAnice()
        {
            Console.WriteLine("Have a nice day");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("See, how ot create an user define function:");
            Console.WriteLine("--------------------------------");
            welcome();
            HaveAnice();
            Console.ReadLine();
        }
    }
}
