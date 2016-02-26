using System;
using System.Linq;
using System.Numerics;
using Library;

namespace Problems._50
{
    public class Problem016 : IProblem
    {
        public void ProblemSolver() {
            const double num = 2;
            const int power = 1000;
            var result = BigInteger.Pow((BigInteger)num, power);
            var comObj = new Commons();
            var digits = comObj.ConvertNumberToArrayOfDigits(result);
            var sumOfDigits = digits.Sum();
            Console.WriteLine("{0} ^ {1} = {2}. Sum of digits = {3}", num, power, result, sumOfDigits);
        }
    }
}
