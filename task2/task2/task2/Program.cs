using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * 
 * that will support the comparison of different populations' growth. The application must receive from the user the size (number of people) of 2 different populations (A, B) 
 * where population A < population B. 
 * The application must receive from the user the corresponding growth rates (%) of the same populations (A, B) where growth-rate A > growth-rate B. 
 * The application must calculate and present the number of years it takes for the population A to exceed or equal the population of country B, maintaining the growth rates. 
 *
 * A method named YearsForecast must be created to perform the calculation. 
 * 
 * 
 -	Data-Entry: Where the user will input population A, population B, growth-rate A, growth-rate B
-	Decisions (if-then-else): Where population A and B will be compared (pop A< pop B)
    Where growth-rates A and will be compared (growth-rate A > growth-rate B)
-	Method: Where the years calculation will happen
o	Iteration:  while (pop A< pop B)  ...
-	Output of your application as described below.

 */

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of population A");
            int populationA = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the size of population B (must be larger than population A)");
            int populationB = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the rate of growth for population A as a percentage");
            float growthA = float.Parse(Console.ReadLine());
            growthA = growthA / 100;

            Console.WriteLine("Enter the rate of growth for population B as a percentage (must be less than growth rate of population A");
            float growthB = float.Parse(Console.ReadLine());
            growthB = growthB / 100;

            Console.WriteLine(YearsForecast(populationA, populationB, growthA, growthB));
        }

        static int YearsForecast(int popA, int popB, float rateA, float rateB)
        {
            while (popA < popB)
            {
                int increaseA = (int)(popA * rateA);
                popA = popA + increaseA;
                return popA;
            }
            while (popA < popB)
            {
                int increaseB = (int)(popB * rateB);
                popB = popB + increaseB;
                return popB;
            }
        }

    }
}
