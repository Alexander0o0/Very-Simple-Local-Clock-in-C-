using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Clock
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("===================");
                Console.WriteLine(DateTime.Now);
                Thread.Sleep(1000);
            }
        }
    }
}
