using System;
using Library;
using Problems;

namespace Problems_50 {
    public class Problem005 : IProblem {
        public void ProblemSolver() {
            Console.WriteLine("Smallest multiple");

            var comObjLib = new Commons();

            const long rangeStart = 1L;
            const long rangeEnd = 20L;
            var product = 1L;

            for (var counter = rangeStart; counter <= rangeEnd; counter++) {
                if (!comObjLib.IsPrime(counter)) {
                    continue;
                }
                var validMultiplier = counter;
                while (validMultiplier <= rangeEnd) {
                    validMultiplier *= counter;
                    if (validMultiplier <= rangeEnd) {
                        continue;
                    }
                    validMultiplier /= counter;
                    break;
                }
                product *= validMultiplier;
            }
            Console.WriteLine("Answer : " + product);
        }
    }
}