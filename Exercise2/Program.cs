using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {

        public static void welcome( string name)
        {
            Console.WriteLine("Welcome friend " + name + " !");
        }

        public static void HaveAnice()
        {
            Console.WriteLine("Have a nice day!");
        }

        static void Main(string[] args)
        {
            Console.Write("See, how to create an user define function with parameters :");
            Console.Write("----------------------------------------------------------------");
            string str1;

            Console.WriteLine("Please input a name: ");
            str1 = Console.ReadLine();
            welcome(str1);
            HaveAnice();
            Console.ReadLine();
        }
    }
}
