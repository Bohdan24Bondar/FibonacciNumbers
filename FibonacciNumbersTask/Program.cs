using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciNumbersTask
{
    class Program
    {
        static void Main(string[] args)
        {
            FibonacciController currentApp = new FibonacciController(0, 100);
            currentApp.Run();
            Console.ReadKey();
        }
    }
}
