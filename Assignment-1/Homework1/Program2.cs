/**
 * 
 * Author: Noah Panicola
 * Date:    9-5-18
 * 
 * C#/.NET Development
 * Assignment 1 - Program 2
 */

using System;


namespace Program2 {

    public class Program {

        static void Main(string[] args) {

            double[] nums;
            int numItems;

            PrintMenu();

            // Get the length of the array
            numItems = Convert.ToInt32(Console.ReadLine());

            // Parse the string into an array
            Console.Write("Enter array (separated by spaces):\n> ");
            nums = ParseArray(numItems, Console.ReadLine());

            PrintArray(nums, "Unsorted");

            // Sort the array
            BubbleSort(nums);

            // Print the sorted array
            PrintArray(nums, "Sorted");
        }

        /**
         *  Parses the string of numbers from the user input into an
         *  array of doubles
         */
        static double[] ParseArray(int size, string line) {

            string[] numStrs = line.Split(" ");
            double[] nums = new double[size];

            for (int i = 0; i < size; i++) {
                nums[i] = Convert.ToDouble(numStrs[i]);
            }

            return nums;
        }

        static void BubbleSort(double[] nums) {
            double temp;
            for (int i = 0; i < nums.Length; i++) {
                for (int j = 0; j < nums.Length - 1; j++){
                    if (nums[j] > nums[j + 1]) {
                        temp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = temp;
                    }
                }
            }
        }

        static void PrintArray(double[] nums, string title) {
            Console.Write(title + ": ");
            for (int i = 0; i < nums.Length; i++)
                Console.Write(nums[i] + " ");

            Console.WriteLine();
        }

        static void PrintMenu() {
            Console.Write("This program will sort an array.\n");
            Console.Write("Enter the amount of numbers to sort: \n> ");
        }

    }

}
