using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciNumbersTask
{
    class Viewer
    {
        public const int BACK_LEFT_CURSOR = 2;

        public void ShowNumbers(IEnumerable<int> fibonacciNumbers)
        {
            foreach (var number in fibonacciNumbers)
            {
                Console.Write(string.Format("{0}, ", number));
            }

            Console.SetCursorPosition((Console.CursorLeft - BACK_LEFT_CURSOR), 
                    Console.CursorTop);
            Console.WriteLine(" ");
        }
    }
}
