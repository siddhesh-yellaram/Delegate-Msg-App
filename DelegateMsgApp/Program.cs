using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateMsgApp
{
    class Program
    {
        delegate void DPrintMsg(string msg);
        static void Main(string[] args)
        {
            DPrintMsg msg;
            msg = PrintHello;
            msg("Siddhesh");
            msg += PrintHello;
            msg += PrintGoodBye;
            msg("Sid");
            Console.ReadLine();
        }

        static void PrintHello(string name)
        {
            Console.WriteLine("Hello " + name);
        }

        static void PrintGoodBye(string name)
        {
            Console.WriteLine("Good Bye " + name);
        }

        static void foo()
        {

        }
    }
}
