using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericEventHandler
{
    class Program
    {
        static void Main(string[] args)
        {
            DemoClass d = new DemoClass();
            d.myOddEvenEvent += Msg;
            

            int x = Convert.ToInt32(Console.ReadLine());

            d.DoAction(x);
        }

        public static void Msg(object sender, EventHandlerArgs e)
        {
            Console.WriteLine("HI I am an {0} Number.",e.Result);
        }
    }

    public class DemoClass
    {
        public event EventHandler<EventHandlerArgs> myOddEvenEvent;

        public void DoAction(int a)
        {
            if (a % 2 == 0)
            {
                myOddEvenEvent?.Invoke(this, new EventHandlerArgs("Even"));
            }
            else
            {
                myOddEvenEvent?.Invoke(this, new EventHandlerArgs("Odd"));
            }
        }
    }

    public class EventHandlerArgs : EventArgs
    {
        public string Result;
        public EventHandlerArgs(string val)
        {
            Result = val;
        }
    }
}
