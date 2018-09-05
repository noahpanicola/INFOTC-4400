/**
 * 
 * Author: Noah Panicola
 * Date:    9-5-18
 * 
 * C#/.NET Development
 * Assignment 1 - Program 1
 * 
 */

using System;
using System.Collections;

namespace Program1 {

    class Program {

        static void Main(string[] args) {

            int n = -1;
            String userInput = null;

            PrintMenu();

            // get the user input
            userInput = Console.ReadLine();
            n = Convert.ToInt32(userInput);

            // Populate a prime number array list and print it to the console
            PrintResult(GetPrimeNumbers(n), n);
        }

        static ArrayList GetPrimeNumbers(int n) {

            ArrayList primeNumbers = new ArrayList();
            bool isPrimeNumber;
            decimal sqrt;

            for (int i = 2; i <= n; i++) {

                isPrimeNumber = true;
                sqrt = Math.Ceiling(Convert.ToDecimal(Math.Sqrt(i)));

                for (int j = 2; j <= sqrt; j++) {
                    if(i != j && i % j == 0) {
                        isPrimeNumber = false;
                    }
                }

                if(isPrimeNumber == true) {
                    primeNumbers.Add(i);
                }

            }

            return primeNumbers;
        }

        static void PrintNumberArrayList(ArrayList list) {

            for (int i = 0; i < list.Count; i++) {
                Console.Write(list[i] + " ");
            }

            Console.WriteLine();
        }

        static void PrintMenu() {
            Console.WriteLine("This program will display every prime number less than or equal to the number provided.");
            Console.Write("Enter a positive integer: ");
        }

        static void PrintResult(ArrayList primeNumbers, int n) {
            Console.WriteLine("\n---------------------------------------------");
            Console.WriteLine("Prime Numbers from 1 to " + n + "\n");
            PrintNumberArrayList(primeNumbers);
            Console.WriteLine("---------------------------------------------");
        }

    }
}
