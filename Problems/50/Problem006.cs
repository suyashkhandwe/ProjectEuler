using System;

namespace Problems._50 {
    public class Problem006 : IProblem {
        public void ProblemSolver() {
            Console.WriteLine("Sum square difference");

            const int n = 100;
            const long sumOfSquares = n*(n + 1)*(2*n + 1)/6L;
            const long sumOfNumbers = n*(n + 1)/2L;
            const long squareOfSum = sumOfNumbers*sumOfNumbers;
            Console.WriteLine("Difference between the sum of the squares and the square of the sum : {0}",
                (squareOfSum - sumOfSquares));
        }
    }
}