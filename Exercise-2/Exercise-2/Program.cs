/**
 * Author: Noah Panicola
 * 8-27-18
 * Exercise 2
 */

using System;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Grade Number: ");
            double score = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Letter Grade: " + getLetterGrade(score));
        }

        static char getLetterGrade(double score) 
        {
            // error check parameter
            if (score > 100 || score < 0) return 'N';

            // return the correct score
            if (score >= 90)
            {
                return 'A';
            }
            else if (score >= 80)
            {
                return 'B';
            }
            else if (score >= 70) 
            {
                return 'C';
            }
            else if (score >= 60)
            {
                return 'D';
            }
            else 
            {
                return 'E';
            }
        }
    }
}
