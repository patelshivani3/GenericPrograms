using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericPrograms
{
    internal class MaxNumber<T> where T : IComparable
    {
        //Creating class

        public T first, second, third;
        public T[] value;
        public MaxNumber(T first, T second, T third)
        {
            this.first = first;
            this.second = second;
            this.third = third;
        }

        // Refactor -1
        //Creating method to find maximum  by using Generic method
        public static T GenericMaxNumber(T first, T second, T third)          
        {

            if ((first.CompareTo(second) > 0) && (first.CompareTo(third) > 0))
            {
                return first;
            }
            else if ((second.CompareTo(first) > 0) && (second.CompareTo(third) > 0))
            {
                return second;
            }
            else
            {
                return third;
            }
        }
    }
    public class MaxNumber1
    {   
        
        //UC1 Maximum Integer Number
        public static void IntNumber()
        {
            int a = 32;
            int b = 50;
            int c = 85;
            Console.WriteLine("Find Maximum Number From ( 32 , 50 , 85)");
            if ((a.CompareTo(b) > 0) && (a.CompareTo(c) > 0))
                Console.WriteLine("The maximum Number is : " + a);
            else if ((b.CompareTo(a) > 0) && (b.CompareTo(c) > 0))
                Console.WriteLine("The Maximum Number is : " + b);
            else
                Console.WriteLine("The Maximum Number is : " + c);
        }

        //UC2 Maximum Float Number
        public static void FloatNumber()
        {
            float a = 3.2f;
            float b = 6.8f;
            float c = 5.5f;
            Console.WriteLine("Find Maximum Number From ( 3.2 , 6.8 , 5.5)");
            if ((a.CompareTo(b) > 0) && (a.CompareTo(c) > 0))
                Console.WriteLine("The maximum Number is : " + a);
            else if ((b.CompareTo(a) > 0) && (b.CompareTo(c) > 0))
                Console.WriteLine("The Maximum Number is : " + b);
            else
                Console.WriteLine("The Maximum Number is : " + c);
        }
        //UC3 Maximum String Number
        public static void StringNumber()
        {
            string a = "Apple";
            string b = "Peach";
            string c = "Banana";
            Console.WriteLine("Find Maximum string From ( Apple , Peach , Banana)");
            if ((a.CompareTo(b) > 0) && (a.CompareTo(c) > 0))
                Console.WriteLine("The Maximum String is : " + a);
            else if ((b.CompareTo(a) > 0) && (b.CompareTo(c) > 0))
                Console.WriteLine("The Maximum String is : " + b);
            else
                Console.WriteLine("The Maximum String is : " + c);
        }
    }
}
