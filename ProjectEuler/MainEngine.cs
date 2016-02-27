using System;
using System.Diagnostics;
using Problems._100;

namespace ProjectEuler {
    internal static class MainEngine {
        public static void Main(String[] args) {
            var watch = Stopwatch.StartNew();

            new Problem067().ProblemSolver();

            watch.Stop();
            var ms = watch.ElapsedMilliseconds;

            Console.WriteLine(@"Total execution time : {0} ms (~{1} s)", ms, ms/1000);
        }
    }
}