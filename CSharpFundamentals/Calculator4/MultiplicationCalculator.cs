using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator4
{
    public class MultiplicationCalculator : Calculator
    {
        public MultiplicationCalculator(string expression) : base(expression)
        {

        }

        public override void Calculate()
        {
            if (Operator == "*")
            {
                Console.WriteLine($"{LeftNumber}{Operator}{RightNumber} = {LeftNumber * RightNumber}");
            }
        }
    }
}
