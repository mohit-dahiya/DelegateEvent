using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseEvent
{
    class Program
    {
        static void Main(string[] args)
        {
            DemoClass d = new DemoClass();
            d.myEvenEvent += evenMsg;
            d.myOddEvent += oddMsg;

            int x = Convert.ToInt32(Console.ReadLine());

            d.DoAction(x);
        }

        public static void evenMsg()
        {
            Console.WriteLine("HI I am an Even Number.");
        }

        public static void oddMsg()
        {
            Console.WriteLine("HI I am an Odd Number.");
        }
    }

    public class DemoClass
    {
        public delegate void evenOddDelegate();
        public event evenOddDelegate myEvenEvent;
        public event evenOddDelegate myOddEvent;

        public void DoAction(int a)
        {
            if (a % 2 == 0)
            {
                myEvenEvent?.Invoke();
            }
            else
            {
                myOddEvent?.Invoke();
            }
        }
    }
}
