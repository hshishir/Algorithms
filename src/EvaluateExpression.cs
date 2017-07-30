using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class EvaluateExpression
    {
        private Stack<double> stackvalue;
        private Stack<string> stackoperand;

        public EvaluateExpression()
        {
            stackvalue = new Stack<double>();
            stackoperand = new Stack<string>();
        }

        public void Run(string expression)
        {
            var tokens = expression.Split(new char[] { ' ' });
            foreach (var token in tokens)
            {
                Console.WriteLine($"{token} Operand:{IsOperand(token)}");
            }
        }

        private bool IsOperand(string val)
        {
            switch (val)
            {
                case "+":
                case "-":
                case "*":
                case "/":
                    return true;
                default:
                    return false;
            }
        }
    }
}
