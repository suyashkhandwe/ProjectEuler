using System;

namespace Problems._50 {
    public class Problem014 : IProblem {
        public void ProblemSolver() {
            Console.WriteLine("Longest Collatz sequence");

            long startingNum = 1000000;
            var maxSequenceLength = -1;
            long numWithMaxSequenceLength = -1;
            while (startingNum >= 1) {
                var sequenceLength = CountCollatzSequenceLength(startingNum);
                if (sequenceLength > maxSequenceLength) {
                    maxSequenceLength = sequenceLength;
                    numWithMaxSequenceLength = startingNum;
                }
                startingNum--;
            }
            Console.WriteLine("numWithMaxSequenceLength = {0} Sequence Length = {1}", numWithMaxSequenceLength, maxSequenceLength);
        }

        private static int CountCollatzSequenceLength(long num) {
            var seqLength = 0;
            while (num > 1) {
                num = (num%2) == 0 ? (num/2) : (3*num + 1);
                seqLength++;
            }
            return seqLength;
        }
    }
}

