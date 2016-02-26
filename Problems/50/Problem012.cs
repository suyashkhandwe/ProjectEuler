using System;
using Library;

namespace Problems._50 {
    public class Problem012 : IProblem {
        public void ProblemSolver() {
            Console.WriteLine("Highly divisible triangular number");

            var n = 1L;
            const int requiredFactorCount = 501;

            var comObj = new Commons();
            var primeNumbers = comObj.GetPrimesInRange(2000000L);
            while (true) {
                var triangleNoForN = n*(n + 1)/2;
                var countOfFactors = comObj.GetCountOfFactors(triangleNoForN, primeNumbers);
                if (countOfFactors >= requiredFactorCount) {
                    Console.WriteLine("Triangle # - " + triangleNoForN);
                    break;
                }
                n++;
            }
        }
    }
}