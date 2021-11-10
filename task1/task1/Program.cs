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


namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //initialize variables

            int voters = 0; // the number of voters
            int voteNum = 0; // the number that a person voted
            int aprilVotedNum = 0; // show how many votes April get
            int billVotedNum = 0; // show how many votes Bill get
            int claireVotedNum = 0; // show how many votes claire get
            bool keepGoing = true; 

            /* ------------------------------------------------------------------ */

            //get the number of voters from user
            do
            {
                try
                {
                    Console.Write("How many voters in your region?: ");
                    voters = int.Parse(Console.ReadLine());
                    Console.WriteLine(" ");
                    keepGoing = false;
                }

                catch (FormatException fEx)
                {
                    Console.WriteLine("* You must enter a number. Please Enter one more time.");
                    Console.WriteLine(" ");
                    keepGoing = true;
                } 

            } while (keepGoing);

            /* --------------------------------------------------------------------- */

            //Ask users what candidate that they want to vote

            for (int i = 0; i < voters; i++)
            {

                do
                {

                    try
                    {
                        Console.Write("There are three candidates - enter number 1 for April, enter number 2 for Bill, enter number 3 for Claire: ");
                        voteNum = int.Parse(Console.ReadLine());
                        keepGoing = false;

                        if (voteNum == 1)
                        {
                            aprilVotedNum++;
                        }
                        else if (voteNum == 2)
                        {
                            billVotedNum ++;

                        }
                        else if (voteNum == 3)
                        {
                            claireVotedNum++;

                        }
                        else
                        {
                            throw new FormatException("* You must enter an one digit number. Please enter one more time.");
                        }
                    }

                    catch (FormatException fEx)
                    {
                        //If the user put a number that's not 1-4
                        Console.WriteLine("* You must enter a number from 1 to 4 to vote for a candidater. Please enter one more time.");
                        Console.WriteLine(" ");
                        keepGoing = true;
                    }

                    catch (OverflowException oEx)
                    {
                        Console.WriteLine("* You must enter an one digit number. Please enter one more time.");
                        Console.WriteLine(" ");
                        keepGoing = true;
                    }

                } while (keepGoing);

            }

            /* --------------------------------------------------------------------- */

            // Show people results

            Console.WriteLine("Candidate April: " + aprilVotedNum + " votes.");
            Console.WriteLine("Candidate Bill: " + billVotedNum + " votes.");
            Console.WriteLine("Candidate Claire: " + claireVotedNum + " votes.");

        }   
    }
}
