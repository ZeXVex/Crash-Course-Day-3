using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    class Program
    {

        public static int SumCal(int num)
        {
            string n1 = Convert.ToString(num);
            int sum = 0;
            for (int i = 0; i < n1.Length; i++)
                sum += Convert.ToInt32(n1.Substring(i, 1));
            return sum;
        }
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Ccalculate the sum of the individual digits of a number: ");
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.Write("Enter a number: ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The sum of the digits of the number {0} is : {1}", num, SumCal(num));
            Console.ReadLine();
        }
    }
}
