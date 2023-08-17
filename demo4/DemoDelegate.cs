using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2210A_CSharp.demo4
{
    internal class DemoDelegate
    {
        public void SayHello(string message)
        { 
            Console.WriteLine(message); 
        }

        public static void Goodbye(string message) 
        { 
            Console.WriteLine(message);
        }
    }
}
