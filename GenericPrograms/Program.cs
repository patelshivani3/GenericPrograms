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

            //UC4 5 parameters
            //INTEGER
            Console.WriteLine("Enter Any 5 Integer Numbers:");
            int firstInt = Convert.ToInt32(Console.ReadLine());
            int secondInt = Convert.ToInt32(Console.ReadLine());
            int thirdInt = Convert.ToInt32(Console.ReadLine());
            int fourthInt = Convert.ToInt32(Console.ReadLine());
            int fifthInt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Max Value:" + MaxNumber<int>.GenericMaxNumber(firstInt, secondInt, thirdInt, fourthInt, fifthInt));
            Console.WriteLine("-----------------------------------------------------");
            //FLOATS
            Console.WriteLine("Enter Any 5 Float Numbers:");
            float firstFloat = Convert.ToSingle(Console.ReadLine());
            float secondFloat = Convert.ToSingle(Console.ReadLine());
            float thirdFloat = Convert.ToSingle(Console.ReadLine());
            float fourthFloat = Convert.ToSingle(Console.ReadLine());
            float fifthFloat = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Max Value:" + MaxNumber<float>.GenericMaxNumber(firstFloat, secondFloat, thirdFloat, fourthFloat, fifthFloat));
            Console.WriteLine("-----------------------------------------------------");
            // STRINGS
            Console.WriteLine("Enter Any 5 Strings:");
            string firstString = Convert.ToString(Console.ReadLine());
            string secondString = Convert.ToString(Console.ReadLine());
            string thirdString = Convert.ToString(Console.ReadLine());
            string fourthString = Convert.ToString(Console.ReadLine());
            string fifthString = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Max Value:" + MaxNumber<string>.GenericMaxNumber(firstString, secondString, thirdString, fourthString, fifthString));
            Console.ReadLine();
        }
    }
}
