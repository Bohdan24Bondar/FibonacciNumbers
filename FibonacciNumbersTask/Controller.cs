using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciNumbersTask
{
    class FibonacciController
    {
        private int _startRange;
        private int _finishRange;

        public FibonacciController(int startRange, int finishRange)
        {
            _startRange = startRange;
            _finishRange = finishRange;
        }

        public void Run()
        {
            FibonacciNumbersCreator creator = new FibonacciNumbersCreator(_startRange, _finishRange);
            IEnumerable<int> numbers = creator.GetFibonacciNumbers();
            Viewer fibonacchiView = new Viewer();
            fibonacchiView.ShowNumbers(numbers);  
        }
    }
}
