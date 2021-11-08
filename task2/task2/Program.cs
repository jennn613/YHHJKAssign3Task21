/* 
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

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {

            // initialize variables 

            int populationA = 0;
            int populationB = 0;
            float growthA = 0;
            float growthB = 0;


            /*   -----------------------------------------------------    */

            //get user inputs
            /*Console.WriteLine("Enter the size of population A");
            populationA = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the size of population B (must be larger than population A)");
            populationB = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the rate of growth for population A as a percentage");
            growthA = float.Parse(Console.ReadLine()) / 100;

            Console.WriteLine("Enter the rate of growth for population B as a percentage (must be less than growth rate of population A");
            growthB = float.Parse(Console.ReadLine()) / 100;*/

            if (populationA < populationB && growthA > growthB)
            {
                YearsForecast(populationA, populationB, growthA, growthB);
                Console.WriteLine(YearsForecast(populationA, populationB, growthA, growthB)); // just to test if it works

            }
            else if (populationA > populationB)
            {
                try
                {
                    Console.WriteLine("Enter the size of population A");
                    populationA = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException fEx)
                {
                    Console.WriteLine("Please enter a valid number.");
                    Console.WriteLine("");
                }
                try
                {
                    Console.WriteLine("Enter the size of population B");
                    populationB = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException fEx)
                {
                    Console.WriteLine("Please enter a valid number.");
                    Console.WriteLine("");
                }
            }
            else
            { // when users entered A>B or growthA < growthB
                try
                {
                    Console.WriteLine("Enter the rate of growth for population A as a percentage");
                    growthA = float.Parse(Console.ReadLine()) / 100;
                }
                catch (FormatException fEx)
                {
                    Console.WriteLine("Please enter a valid number.");
                    Console.WriteLine("");
                }
                try
                {
                    Console.WriteLine("Enter the rate of growth for population B as a percentage");
                    growthB = float.Parse(Console.ReadLine()) / 100;
                }
                catch (FormatException fEx)
                {
                    Console.WriteLine("Please enter a valid number.");
                    Console.WriteLine("");
                }

            }
            
            Console.WriteLine("Maintaining the growth rates, popullation A will be equal to or bigger than population B in " + YearsForecast(populationA, populationB, growthA, growthB) + " years.");
            
        }

         static int YearsForecast (int popA, int popB, float rateA, float rateB)
          {

            int increaseA = popA * Convert.ToInt32(rateA);
            int increaseB = popB * Convert.ToInt32(rateB); // I want you to change the names of variables bc I don't think mines are good. maybe also commits too! Thanks ><
            int year = 0;

           // calculate the number of years it takes for the population A to exceed or equal the population of country B, maintaining the growth rates.
              while (popA < popB)
              {
                year++;

                popA = (year * increaseA) + popA;
                popB = (year * increaseB)+ popB;
              }
            return year; // I think we need to return the year to let users know how long does it take. And I can't get the meaning of maintaing the growth rates. I can't figure out what cna we do with them.
        }
}
}
