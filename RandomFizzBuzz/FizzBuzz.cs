using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomFizzBuzz
{
    public class FizzBuzz
    {
        #region Methods
        public string PrintNumber(int number)
        {
            string printOut = null;
            if(number%3 == 0 && number%5 == 0)
            { printOut = "FizzBuzz"; }
            else if (number%3 == 0)
            { printOut = "Fizz"; }
            else if(number%5 == 0)
            { printOut = "Buzz"; }
            else
            { printOut = number.ToString(); }
            return printOut;
        }

        #endregion
        #region constructors
        public FizzBuzz()
        {

        }
       #endregion
    }
}
