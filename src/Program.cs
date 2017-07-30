using System;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            var ee = new EvaluateExpression();
            var expression = "{ 1 + 2 } * { 3 + 4 }";
            ee.Run(expression);
        }
    }
}
