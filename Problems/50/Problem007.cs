using System;
using Library;

namespace Problems._50 {
    public class Problem007 : IProblem {
        public void ProblemSolver() {
            Console.WriteLine("10001st prime");
            var primeNumbers = new Commons().GetPrimesInRange(120000L);

            Console.WriteLine("10001st primer number : {0}", primeNumbers[10000]);
        }
    }
}
