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

        public T first, second, third, fourth, fifth;
        public MaxNumber(T first, T second, T third ,T fourth ,T fifth)
        {
            this.first = first;
            this.second = second;
            this.third = third;
            this.fourth = fourth;
            this.fifth = fifth;
        }
        
        //Creating method to find maximum  by using Generic method
        public static T GenericMaxNumber(T first, T second, T third,T fourth, T fifth)          
        {

            if ((first.CompareTo(second) > 0) && (first.CompareTo(third) > 0) && (first.CompareTo(fourth) > 0) && (first.CompareTo(fifth) > 0))
            {
                return first;
            }
            else if ((second.CompareTo(first) > 0) && (second.CompareTo(third) > 0) && (second.CompareTo(fourth) > 0) && (second.CompareTo(fifth) > 0))
            {
                return second;
            }
            else if ((third.CompareTo(first) > 0) && (third.CompareTo(second) > 0) && (third.CompareTo(fourth) > 0) && (third.CompareTo(fifth) > 0))
            {
                return third;
            }
            else if ((fourth.CompareTo(first) > 0) && (fourth.CompareTo(second) > 0) && (fourth.CompareTo(third) > 0) && (fourth.CompareTo(fifth) > 0))
            {
                return fourth;
            }
            else
            {
                return fifth;
            }
        }
        public void TestMaximum()
        {
            var result = GenericMaxNumber(first, second, third , fourth,fifth);
            Console.WriteLine("The Result for maximum number is : " + result);
        }
    }
}
