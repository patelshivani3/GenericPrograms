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
            Console.WriteLine("\n1.Maximum Integer");
            int option = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("--------------------------------------");
            switch(option)
            {
                case 1:
                    MaxNumber.Number();
                    break;
            }
            Console.ReadLine();
        }
    }
}
