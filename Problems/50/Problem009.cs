using System;

namespace Problems._50 {
    public class Problem009 : IProblem {
        public void ProblemSolver() {
            Console.WriteLine("Special Pythagorean triplet");
            for (var a = 1; a <= 1000; a++) {
                for (var b = 1; b <= 1000; b++) {
                    for (var c = 1; c <= 1000; c++) {
                        if (a + b + c != 1000)
                            continue;
                        
                        // ReSharper disable once CompareOfFloatsByEqualityOperator
                        if (Math.Pow(a, 2) + Math.Pow(b, 2) != Math.Pow(c, 2))
                            continue;

                        Console.WriteLine(@"abc = {0}", (a*b*c));
                        return;
                    }
                }
            }
        }
    }
}