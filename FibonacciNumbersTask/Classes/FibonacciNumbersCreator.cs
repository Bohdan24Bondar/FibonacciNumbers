using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciNumbersTask
{
    class FibonacciNumbersCreator
    {
        #region Consts

        public const int FIRST_FIBONACCI_NUMBER = 0;
        public const int SECOND_FIBONACCI_NUMBER = 1;

        #endregion

        public int StartRange { get; private set; }

        public int FinishRange { get; private set; }

        public FibonacciNumbersCreator(int startRange, int finishRange)
        {
            StartRange = startRange;
            FinishRange = finishRange;
        }

        private void NormalizeNumbers(out int firstNumber, out int secondNumber)
        {
            firstNumber = FIRST_FIBONACCI_NUMBER;
            secondNumber = SECOND_FIBONACCI_NUMBER;

            while (StartRange > firstNumber)//TODO
            {
                int previous = firstNumber;
                firstNumber = secondNumber;
                secondNumber += previous;
            }
        }

        public IEnumerable<int> GetFibonacciNumbers()
        {
            int firstNumber;
            int secondNumber;

            NormalizeNumbers(out firstNumber, out secondNumber);

            yield return firstNumber;

            while (secondNumber <= FinishRange)
            {
                yield return secondNumber;

                int previousNumber = firstNumber;
                firstNumber = secondNumber;
                secondNumber += previousNumber;
            }
        }
































        //public IEnumerable<int> GetFibonacciNumbers()
        //{
        //    int firstNumber;
        //    int secondNumber;

        //    CalculateNumbers(out firstNumber, out secondNumber);

        //    int previous = 0;

        //    while (secondNumber <= (FinishRange + previous))
        //    {
        //        yield return firstNumber;

        //        previous = firstNumber;
        //        firstNumber = secondNumber;
        //        secondNumber += previous;
        //    }
        //}
    }
}
