using System;
using System.Linq;
using Library;
using Problems;

namespace Problems_50 {
    public class Problem002 : IProblem {
        /// <summary>
        /// Solves Problem 002
        /// </summary>
        public void ProblemSolver() {
            Console.WriteLine("Even Fibonacci numbers");
            var comObj = new Commons();
            var fibonacciSeries = comObj.GenerateFibonacciSeries(1, 1, 4000000);
            var sum = fibonacciSeries.Where(comObj.IsEven).Sum();
            Console.WriteLine("Sum : {0}", sum);
        }
    }
}