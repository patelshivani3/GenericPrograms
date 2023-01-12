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
            Console.WriteLine("\n1.Maximum Integer Number\n2.Maximum Float Number\n3.Maximum String\n4.Refactor Maximum Number Using Generic Method\n5.Refactor Maximum Number Using Generic Class");
            int option = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("==================================================");
            switch(option)
            {
                case 1:
                    MaxNumber<int>.IntNumber();
                    break;

                case 2:
                    MaxNumber<float>.FloatNumber();
                    break;

                case 3:
                    MaxNumber<string>.StringNumber();
                    break;

                case 4:
                    {   // UC3 Refactor-1 
                        //INTEGER
                        Console.WriteLine("Enter Any 3 Integer Numbers:");
                        int firstInt = Convert.ToInt32(Console.ReadLine()); 
                        int secondInt = Convert.ToInt32(Console.ReadLine());                   
                        int thirdInt = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Max Value:" + MaxNumber<int>.GenericMaxNumber(firstInt, secondInt, thirdInt));
                        Console.WriteLine("-----------------------------------------------------");
                        //FLOATS
                        Console.WriteLine("Enter Any 3 Float Numbers:");
                        float firstFloat = Convert.ToSingle(Console.ReadLine());                        
                        float secondFloat = Convert.ToSingle(Console.ReadLine());                        
                        float thirdFloat = Convert.ToSingle(Console.ReadLine());
                        Console.WriteLine("Max Value:" + MaxNumber<float>.GenericMaxNumber(firstFloat, secondFloat, thirdFloat));
                        Console.WriteLine("-----------------------------------------------------");
                        // STRINGS
                        Console.WriteLine("Enter Any 3 Strings:");
                        string firstString = Convert.ToString(Console.ReadLine());                        
                        string secondString = Convert.ToString(Console.ReadLine());                        
                        string thirdString = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("Max Value:" + MaxNumber<string>.GenericMaxNumber(firstString, secondString, thirdString));
                    }
                    break;

                case 5:
                    {   // UC3 Refactor-2 
                        //INTEGER
                        Console.WriteLine("Enter Any 3 Integer Numbers:");
                        int firstInt = Convert.ToInt32(Console.ReadLine());
                        int secondInt = Convert.ToInt32(Console.ReadLine());
                        int thirdInt = Convert.ToInt32(Console.ReadLine());
                        MaxNumber<int> obj1 = new MaxNumber<int>(firstInt, secondInt, thirdInt); 
                        obj1.TestMaximum();
                        Console.WriteLine("-----------------------------------------------------");
                        //FLOATS
                        Console.WriteLine("Enter Any 3 Float Numbers:");
                        float firstFloat = Convert.ToSingle(Console.ReadLine());
                        float secondFloat = Convert.ToSingle(Console.ReadLine());
                        float thirdFloat = Convert.ToSingle(Console.ReadLine());
                        MaxNumber<float> obj2 = new MaxNumber<float>(firstFloat, secondFloat, thirdFloat);
                        obj2.TestMaximum();
                        Console.WriteLine("-----------------------------------------------------");
                        // STRINGS
                        Console.WriteLine("Enter Any 3 Strings:");
                        string firstString = Convert.ToString(Console.ReadLine());
                        string secondString = Convert.ToString(Console.ReadLine());
                        string thirdString = Convert.ToString(Console.ReadLine());
                        MaxNumber<string> obj3 = new MaxNumber<string>(firstString, secondString, thirdString);
                        obj3.TestMaximum();
                    }
                    break;

                default:
                    Console.WriteLine("Choose from given options only..");
                    break;
            }
            Console.ReadLine();
        }
    }
}
