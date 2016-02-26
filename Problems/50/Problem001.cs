using System;

namespace Problems._50 {
    public class Problem001 : IProblem {
        /// <summary>
        /// Solves Problem 001
        /// </summary>
        public void ProblemSolver() {
            Console.WriteLine("Multiples of 3 and 5");
            var sum = 0;
            for (var counter = 1; counter < 1000; counter++) {
                sum += (counter%3 == 0 || counter%5 == 0) ? counter : 0;
            }
            Console.WriteLine("Sum is {0}", sum);
        }
    }
}