using System;
using System.Globalization;
using Library;

namespace Problems._50 {
    public class Problem004 : IProblem {
        public void ProblemSolver() {
            Console.WriteLine("Largest palindrome product");

            var comObjLib = new Commons();
            var largestProduct = 0;
            for (var num1 = 999; num1 >= 100; num1--) {
                for (var num2 = 999; num2 >= 100; num2--) {
                    var product = num1*num2;
                    if (comObjLib.IsPalindrome(product.ToString(CultureInfo.InvariantCulture))) {
                        largestProduct = Math.Max(product, largestProduct);
                    }
                }
            }
            Console.WriteLine("Largest palindrome made from the product of two 3-digit numbers : {0}", largestProduct);
        }
    }
}