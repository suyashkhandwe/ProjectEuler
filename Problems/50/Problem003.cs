using System;
using Library;
using Problems;

namespace Problems_50 {
    public class Problem003 : IProblem {
        public void ProblemSolver() {
            Console.WriteLine("Largest prime factor");
            var comObj = new Commons();
            const long givenNo = 600851475143L;
            var largestPrimeFactor = comObj.GetLargestPrimeFactor(givenNo);
            Console.WriteLine("Largest prime factor is : {0}", largestPrimeFactor);
        }
    }
}