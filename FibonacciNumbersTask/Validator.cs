using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciNumbersTask
{
    class Validator
    {
        public string StartRange { get; private set; }

        public string FinishRange { get; private set; }

        public Validator(string startRange, string finishRange)
        {
            StartRange = startRange;
            FinishRange = finishRange;
        }   
    }
}
