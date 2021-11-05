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
            while (popA<popB)
            {
                int increaseA = (int)(popA * rateA);
                popA = popA + increaseA;

                int increaseB = (int)(popB * rateB);
                popB = popB + increaseB;
                return popA;
            }
        }
    }
}
