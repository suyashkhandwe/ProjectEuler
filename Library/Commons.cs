using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Library {
    public class Commons {

        /// <summary>
        /// Generates Fibonacci Series starting with the given 2 numbers within the given range
        /// </summary>
        /// <param name="firstNum">First number</param>
        /// <param name="secondNum">Second number</param>
        /// <param name="range">Maximum or highest number</param>
        public List<long> GenerateFibonacciSeries(long firstNum, long secondNum, long range) {
            var series = new List<long> {
                firstNum, secondNum
            };

            var nextNum = 0L;
            var previousNum1 = firstNum;
            var previousNum2 = secondNum;

            while (nextNum <= range) {
                nextNum = previousNum1 + previousNum2;
                series.Add(nextNum);
                previousNum1 = previousNum2;
                previousNum2 = nextNum;
            }
            return series;
        }

        /// <summary>
        /// Generates Fibonacci Series starting with 0 and the given number within the given range
        /// </summary>
        /// <param name="startingNum">Starting number</param>
        /// <param name="range">Maximum or highest number</param>
        public List<long> GenerateFibonacciSeries(long startingNum, long range) {
            return GenerateFibonacciSeries(0, startingNum, range);
        }

        /// <summary>
        /// Generates Fibonacci Series starting with 0 and 1 within the given range
        /// </summary>
        /// <param name="range">Maximum or highest number</param>
        public List<long> GenerateFibonacciSeries(long range) {
            return GenerateFibonacciSeries(0, 1, range);
        }

        /// <summary>
        ///  Checks if the given number is even or odd
        /// </summary>
        /// <param name="num">Number to be tested</param>
        /// <returns>Returns TRUE if the number is EVEN. FALSE if the number is ODD</returns>

        public bool IsEven(long num) {
            return num%2 == 0;
        }

        /// <summary>
        /// Checks if the given number is prime or not
        /// </summary>
        /// <param name="num">Number to be tested</param>
        /// <returns>Returns TRUE if the number is PRIME. FALSE otherwise</returns>
        public bool IsPrime(long num) {
            if (num < 2) {
                return false;
            }
            if (num == 2) {
                return true;
            }
            for (var counter = 2; counter <= Math.Sqrt(num); counter++) {
                if (num%counter == 0) {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Gets all the factors for the given number
        /// </summary>
        /// <param name="num">Number which needs to be factorized</param>
        /// <param name="getOnlyPrime">TRUE if only prime factors are required. FALSE to get all factors</param>
        /// <returns>List of Long type with the factors for the given number</returns>
        public List<long> Factorize(long num, bool getOnlyPrime) {
            var factors = new List<long>();

            for (var counter = 1L; counter <= num; counter++) {
                if (num%counter != 0) {
                    continue;
                }
                num /= counter;
                if (getOnlyPrime) {
                    if (IsPrime(counter)) {
                        factors.Add(counter);
                    }
                }
                else {
                    factors.Add(counter);
                }
            }
            return factors;
        }

        /// <summary>
        /// Gets all the factors for the given number
        /// </summary>
        /// <param name="num">Number which needs to be factorized</param>
        /// <param name="primeNumbers">List of prime numbers</param>
        /// <returns>All factors</returns>
        public List<long> GetAllPrimeFactors(long num, List<long> primeNumbers) {
            var factors = new List<long>();

            // ReSharper disable once LoopCanBePartlyConvertedToQuery
            foreach (var divisor in primeNumbers) {
                if (divisor > num) {
                    break;
                }
                while (num > 1) {
                    if (num%divisor != 0) {
                        break;
                    }
                    num /= divisor;
                    if (IsPrime(divisor)) {
                        factors.Add(divisor);
                    }
                }
            }
            return factors;
        }

        /// <summary>
        /// Gets all prime factors for the given number
        /// </summary>
        /// <param name="num">Number for which prime factors are required</param>
        /// <returns>List of Long type with the prime factors for the given number</returns>
        public List<long> GetPrimeFactors(long num) {
            return Factorize(num, true);
        }

        /// <summary>
        /// Checks if the given string is a palindrome or not
        /// </summary>
        /// <param name="text">String which needs to be tested</param>
        /// <returns>TRUE if the given string is a palindrome. FALSE otherwise</returns>
        public bool IsPalindrome(String text) {
            var reversedString = ReverseString(text);
            return reversedString.Equals(text);
        }

        /// <summary>
        /// Reverses the given string
        /// </summary>
        /// <param name="text">String to be reversed</param>
        /// <returns>Reversed string</returns>
        public String ReverseString(String text) {
            var strArray = text.ToCharArray();
            var len = text.Length;
            for (var index = 0; index < len/2; index++) {
                var tempChar = strArray[index];
                strArray[index] = strArray[len - 1 - index];
                strArray[len - 1 - index] = tempChar;
            }
            return new String(strArray);
        }

        /// <summary>
        /// Populates primality for the given range of numbers
        /// </summary>
        /// <param name="range">Highest number for which primality needs to be populated</param>
        /// <returns>An array of bool type where value of each index represents if the number is prime or not</returns>
        public bool[] PopulatePrimality(long range) {
            var primality = new int[(int) (range + 1)];

            primality[0] = -1;
            primality[1] = -1;

            for (var counter = 2; counter <= range; counter++) {
                if (primality[counter] != 0) {
                    continue;
                }
                primality[counter] = IsPrime(counter) ? 1 : -1;
                if (primality[counter] != 2) {
                    continue;
                }
                var primalityUpdateCounter = counter*2;
                while (primalityUpdateCounter <= range) {
                    primality[primalityUpdateCounter] = 1;
                    primalityUpdateCounter += counter;
                }
            }

            var returnPrimality = new bool[(int) (range + 1)];
            for (var index = 0; index <= range; index++) {
                returnPrimality[index] = primality[index] == 1;
            }
            return returnPrimality;
        }

        /// <summary>
        /// Gets prime numbers in the given range
        /// </summary>
        /// <param name="range">Highest number up to which prime numbers are required</param>
        /// <returns>List of Long type which are prime number in the given range</returns>
        public List<long> GetPrimesInRange(long range) {

            var primality = PopulatePrimality(range);

            var primeNumbers = new List<long>();

            for (var counter = 0; counter < range + 1; counter++) {
                if (primality[counter]) {
                    primeNumbers.Add(counter);
                }
            }
            return primeNumbers;
        }

        /// <summary>
        /// Gets the sum of given list of numbers
        /// </summary>
        /// <param name="numbers">List of numbers</param>
        /// <returns>Sum of number</returns>
        public long GetSum(List<long> numbers) {
            return numbers.Sum();
        }

        /// <summary>
        /// Finds out the largest number from the given list
        /// </summary>
        /// <param name="numbers">List of number</param>
        /// <returns>Largest number form the given list</returns>
        public long GetLargestNumberFromCollection(List<long> numbers) {
            var largestNo = 0L;

            // ReSharper disable once LoopCanBeConvertedToQuery
            foreach (var number in numbers) {
                largestNo = Math.Max(number, largestNo);
            }
            return largestNo;
        }

        /// <summary>
        /// Gets the largest prime factor of the given number
        /// </summary>
        /// <param name="number">Number for which largest prime factor needs to be found</param>
        /// <returns>Largest prime factor of the given number</returns>
        public long GetLargestPrimeFactor(long number) {
            return GetLargestNumberFromCollection(GetPrimeFactors(number));
        }

        /// <summary>
        /// Returns the factorial of the given number
        /// </summary>
        /// <param name="number">Number for which the factorial needs to be calculated</param>
        /// <returns>Factorial of the number</returns>
        public long Factorial(long number) {
            var multiplier = 1L;
            var product = 1L;
            while (multiplier <= number) {
                product *= multiplier++;
            }
            return product;
        }

        /// <summary>
        /// Gets the total number of factors for the given number
        /// </summary>
        /// <param name="number">Number of long type for which count of factors need to be calculated</param>
        /// <param name="primeNumbers">List of prime numbers</param>
        /// <returns>Total number of factors for the given number</returns>
        public int GetCountOfFactors(long number, List<long> primeNumbers) {
            var countOfFactors = 1;

            if (number == 2 || number == 3) {
                return 2;
            }
            var allPrimeFactors = GetAllPrimeFactors(number, primeNumbers);

            allPrimeFactors.Sort();

            var currentPrimeFactorCount = 0;
            var currentPrimeFactor = 1L;


            var newPrimeFactor = 1L;
            var index = 0;
            if (allPrimeFactors.Count <= 0) {
                return countOfFactors;
            }
            while (true) {
                if (index <= allPrimeFactors.Count) {
                    newPrimeFactor = allPrimeFactors[index++];
                }

                if (newPrimeFactor == currentPrimeFactor) {
                    currentPrimeFactorCount++;
                }
                else {
                    currentPrimeFactor = newPrimeFactor;
                    countOfFactors *= (currentPrimeFactorCount + 1);
                    currentPrimeFactorCount = 1;
                }

                if (index < allPrimeFactors.Count) {
                    continue;
                }
                countOfFactors *= (currentPrimeFactorCount + 1);
                break;
            }

            return countOfFactors;
        }

        /// <summary>
        /// Converts the given number into an array of digits
        /// </summary>
        /// <param name="num">Number to be converted to array of digits</param>
        /// <returns>An integer array containing the digits of the given number</returns>
        public int[] ConvertNumberToArrayOfDigits(BigInteger num) {
            var list = new List<int>();
            while (num > 0) {
                var digit = num%10;
                list.Add((int) digit);
                num = (num - digit)/10;
            }
            return list.ToArray();
        }
    }
}