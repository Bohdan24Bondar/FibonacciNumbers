using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciNumbersTask
{
    class RangeValidator
    {
        public string StartRange { get; private set; }

        public string FinishRange { get; private set; }

        public RangeValidator(string startRange, string finishRange)
        {
            StartRange = startRange;
            FinishRange = finishRange;
        }   
    }
}
