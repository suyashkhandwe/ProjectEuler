using System;

namespace Problems._50 {
    public class Problem019 : IProblem {

        private const int YY_START = 1901;
        private const int YY_END = 2000;
        private const int MM_START = 1;
        private const int MM_END = 12;
        private const int DD = 1;

        public void ProblemSolver() {
            var counter = 0;
            for (var yy = YY_START; yy <= YY_END; yy++) {
                for (var mm = MM_START; mm <= MM_END; mm++) {
                    counter += (new DateTime(yy, mm, DD).DayOfWeek == DayOfWeek.Sunday) ? 1 : 0;
                }
            }
            Console.WriteLine("Sundays on 1st of month - {0}", counter);
        }
    }
}