using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nWelcome to Generic Programs");
            Console.WriteLine("\n1.Maximum Integer Number\n2.Maximum Float Number\n3.Maximum String");
            int option = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("--------------------------------------");
            switch(option)
            {
                case 1:
                    MaxNumber.Number();
                    break;

                case 2:
                    MaxNumber.Number1();
                    break;

                case 3:
                    MaxNumber.Number2();
                    break;

                default:
                    Console.WriteLine("Choose from given options only..");
                    break;
            }
            Console.ReadLine();
        }
    }
}
