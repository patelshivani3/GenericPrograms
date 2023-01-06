using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericPrograms
{
    internal class MaxNumber
    {
        public static void Number()
        {
            int a = 32;
            int b = 50;
            int c = 85;
            Console.WriteLine("Find Maximum Number From ( 32 , 50 , 85)");
            if((a.CompareTo(b) > 0) && (a.CompareTo(c) > 0))
                Console.WriteLine("The maximum Number is : "+a);
            else if((b.CompareTo(a) > 0) && (b.CompareTo(c) > 0))
                Console.WriteLine("The Maximum Number is : "+b);
            else
                Console.WriteLine("The Maximum Number is : "+c);

        }
    }
}
