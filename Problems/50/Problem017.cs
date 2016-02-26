using System;
using System.Collections.Generic;

namespace Problems._50 {
    public class Problem017 : IProblem {
        private readonly Dictionary<int, string> wordsValues = new Dictionary<int, string>();

        public void ProblemSolver() {
            Setup();
            const int start = 1;
            const int end = 1000;
            var sum = 0;
            for (var counter = start; counter <= end; counter++) {
                var inWords = GetNumberInWords(counter);
                sum += GetLetterCount(inWords);
            }
            Console.WriteLine("Sum - {0}", sum);
        }

        private static int GetLetterCount(string inWords) {
            return inWords.Replace("-", "").Replace(" ", "").Length;
        }

        private void Setup() {
            wordsValues.Add(0, "");
            wordsValues.Add(1, "One");
            wordsValues.Add(2, "Two");
            wordsValues.Add(3, "Three");
            wordsValues.Add(4, "Four");
            wordsValues.Add(5, "Five");
            wordsValues.Add(6, "Six");
            wordsValues.Add(7, "Seven");
            wordsValues.Add(8, "Eight");
            wordsValues.Add(9, "Nine");
            wordsValues.Add(10, "Ten");
            wordsValues.Add(11, "Eleven");
            wordsValues.Add(12, "Twelve");
            wordsValues.Add(13, "Thirteen");
            wordsValues.Add(14, "Fourteen");
            wordsValues.Add(15, "Fifteen");
            wordsValues.Add(16, "Sixteen");
            wordsValues.Add(17, "Seventeen");
            wordsValues.Add(18, "Eighteen");
            wordsValues.Add(19, "Nineteen");
            wordsValues.Add(20, "Twenty");
            wordsValues.Add(30, "Thirty");
            wordsValues.Add(40, "Forty");
            wordsValues.Add(50, "Fifty");
            wordsValues.Add(60, "Sixty");
            wordsValues.Add(70, "Seventy");
            wordsValues.Add(80, "Eighty");
            wordsValues.Add(90, "Ninety");
        }

        private string GetNumberInWords(int num) {
            var words = "";

            if (num == 1000) {
                words = "One Thousand";
                num = 0;
            }
            if (num < 1000 && num >= 100) {
                var hundredsDigit = num/100;
                num %= 100;
                words = string.Format("{0} hundred", wordsValues[hundredsDigit]);
            }
            if (num < 100 && num > 20) {
                var unitsDigit = num%10;
                var tensDigit = num - unitsDigit;
                words = string.Format("{0} {1} {2}{3}{4}", words, string.IsNullOrEmpty(words) ? "" : "and", wordsValues[tensDigit],
                    (unitsDigit == 0 ? "" : "-"), wordsValues[unitsDigit]);
            }
            if (num <= 20 && num > 0) {
                words = string.Format("{0} {1} {2}", words, string.IsNullOrEmpty(words) ? "" : "and", wordsValues[num]);
            }
            return words;
        }
    }
}