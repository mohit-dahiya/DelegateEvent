using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuticastDelegate
{
    class Program
    {
        public delegate void iAmMulticastDelegate(int x, int y);

        static void Main(string[] args)
        {
            iAmMulticastDelegate iAmMulticast = DemoClass.Sum;
            iAmMulticast += DemoClass.Sub;
            iAmMulticast += DemoClass.Mul;

            iAmMulticast(3, 4);
        }
    }

    public class DemoClass
    {
        public static void Sum(int a, int b)
        {
            Console.WriteLine("Total is :" + (a + b));
        }

        public static void Sub(int a, int b)
        {
            Console.WriteLine("Total is :"+ (a - b));
        }

        public static void Mul(int a, int b)
        {
            Console.WriteLine("Total is :" + (a * b));
        }
    }
}
