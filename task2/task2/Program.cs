﻿/* 
 * Program ID: assignment3
 * 
 * Program Authors:
 *      Yusuf Hafeji
 *      Hyunjin Kim
 * 
 * Purpose: To make a program for counting votes
 * 
 * Revision History:
 *      created Nov 5, 2021 by Yusuf Hafeji and Hyunjin Kim
 *      
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YHHJKAssign3Task2S1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize variables 
            int populationA = 0;
            int populationB = 0;
            float growthA = 0;
            float growthB = 0;
            bool key = true;

            // Try catch statements in do while loops to get user input
            do
            {
                try
                {
                    Console.WriteLine("Enter the size of population A");
                    populationA = Convert.ToInt32(Console.ReadLine());
                    key = false;
                }
                catch (FormatException fEx)
                {
                    Console.WriteLine("Please enter a valid number.");
                    Console.WriteLine("");
                    key = true;
                }
            } while (key);

            do
            {
                try
                {
                    Console.WriteLine("Enter the size of population B");
                    populationB = Convert.ToInt32(Console.ReadLine());
                    key = false;
                }
                catch (FormatException fEx)
                {
                    Console.WriteLine("Please enter a valid number.");
                    Console.WriteLine("");
                    key = true;
                }
            } while (key);

            do
            {
                try
                {
                    Console.WriteLine("Enter the rate of growth for population A as a percentage");
                    growthA = float.Parse(Console.ReadLine()) / 100;
                    key = false;
                }
                catch (FormatException fEx)
                {
                    Console.WriteLine("Please enter a valid number.");
                    Console.WriteLine("");
                    key = true;
                }
            } while (key);

            do
            {
                try
                {
                    Console.WriteLine("Enter the rate of growth for population B as a percentage");
                    growthB = float.Parse(Console.ReadLine()) / 100;
                    key = false;
                }
                catch (FormatException fEx)
                {
                    Console.WriteLine("Please enter a valid number.");
                    Console.WriteLine("");
                    key = true;
                }
            } while (key);

            if (populationA < populationB && growthA > growthB) // If statement that checks if the population and growth rates are the right amount, if it's not then an exception will be thrown
            {
                int years = YearsForecast(populationA, populationB, growthA, growthB);
                Console.WriteLine("Maintaining the growth rates, popullation A will be equal to or bigger than population B in " + years + " years."); 

            }
            else
            {
                throw new Exception("Population a must be smaller than population B, and growth rate of A must be larger than growth rate of B. Please restart the program and try again.");
            }
        }

        static int YearsForecast(int popA, int popB, float rateA, float rateB)  // Method that calculates the growth rate for the populations
        {
            float increaseA = popA * rateA;
            float increaseB = popB * rateB;
            int year = 0;

            while (popA < popB) // While loop that finds the number of years that it will take population A to exceed population B
            {
                year++;

                popA = Convert.ToInt32((year * increaseA) + popA);
                popB = Convert.ToInt32((year * increaseB) + popB);
            }
            return year;
        }
    }
}
