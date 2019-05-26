using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDelegate
{
    class Program
    {
        //Hi. I am a delegate.
        public delegate int iAmDelegate(int x, int y);

        static void Main(string[] args)
        {
            iAmDelegate amDelegate = DemoClass.plus;
            int result =  amDelegate(5, 4);

            Console.WriteLine("here is result: " + result);

            Console.ReadLine();
        }
    }

    class DemoClass
    {
        public static int plus(int a, int b)
        {
            return a + b;
        }
    }
}
