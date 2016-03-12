using System;
using System.Numerics;
using Library;

namespace Problems._50 {
    public class Problem020 : IProblem {
        public void ProblemSolver() {
            const string numberStr = "100";
            var comObj = new Commons();
            var bigNumber = BigInteger.Parse(numberStr);
            var sum = comObj.GetSum(comObj.ConvertNumberToArrayOfDigits(comObj.Factorial(bigNumber)));
            Console.WriteLine("Sum of digits of {0}! is : {1}", bigNumber, sum);
        }
    }
}