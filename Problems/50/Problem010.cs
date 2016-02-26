using System;
using Library;

namespace Problems._50 {
    public class Problem010 : IProblem {
        public void ProblemSolver() {
            Console.WriteLine("Summation of primes");

            const long range = 2000000L;
            var comObj = new Commons();
            var primes = comObj.GetPrimesInRange(range);
            var sum = comObj.GetSum(primes);

            Console.WriteLine("Sum = " + sum);
        }
    }
}