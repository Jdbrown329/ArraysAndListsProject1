using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testArray1 = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };   //TODO: // Create an int Array and populate numbers 1-10

            var evens = new List<int>();
            var odds = new List<int>();      /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */

            for (int i = 0; i<testArray1.Length; i++) 
            {
                if (i%2 == 0)
                {
                  evens.Add(i);
                }
                else if (i%2 >=1)
                {
                    odds.Add(i);
                }
            } /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */

           foreach (var i in evens)
            {
                Console.WriteLine($"{i} is an even number");
            } 
           foreach (var i in odds)
            {
                Console.WriteLine($"{i} is an odd number");
            }/* Now using foeach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */
        }
    }
}
