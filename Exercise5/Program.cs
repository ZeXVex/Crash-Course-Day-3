using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Program
    {
        public static int SbCounter(string sp)
        {
            int spcount = 0;
            string sp1;
            for (int i = 0; i < sp.Length; i++)
            {
                sp1 = sp.Substring(i, 1);
                if (sp1 == " ")
                    spcount++;
            }
            return spcount;
        }

        static void Main(string[] args)
        {
            string sp2;
            Console.WriteLine("Counter for hte number of spaces:");
            Console.WriteLine("---------------------------------------");
            Console.Write("Input a phrase: ");
            sp2 = Console.ReadLine();
            Console.WriteLine("You're phrase contains {0} spaces", SbCounter(sp2));

            Console.ReadLine();
        }
    }
}
