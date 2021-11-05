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
 *      created Nov 5, 2021 by usuf Hafeji and Hyunjin KimY
 *      
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 
that will support the counting and results of an electoral process where there are three candidates (‘April’, ‘Bill’, ‘Claire’). ✓
Ask the users how many voters, would they have in their region, example 10. ✓
Ask each voter to vote for one of the 3 candidates available and at the end of the number of voters, show the number of votes for each candidate and who won. 

Expected code logic in your project:
-	Data-Entry: Where the total number of voters will be informed by the user ✓
-   Iteration: Where the user will inform the candidate (‘April’, ‘Bill’, ‘Claire’) until finish total voters. ✓
-	Decisions (if-then-else): Where the candidate will be identified, and the vote count will happen. ✓
-	Output of your application as described below. ✓
 
 */

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {

            //initialize variables
            int voters = 0; // number of voters
            int voteNum = 0; // the number that a person voted
            int aprilVotedNum = 0; // show how many votes April get
            int billVotedNum = 0; // show how many votes Bill get
            int claireVotedNum = 0; // show how many votes claire get         


            Console.Write("How many voters in your region? : ");
            voters = Convert.ToInt32(Console.ReadLine());

            //Console.Write(voters);
            for (int i = 0; i < voters; i++)
            {

                try
                {
                    Console.WriteLine("There are three candidates - enter number 1 for April, enter number 2 for Bill, enter number 3 for Claire");
                    voteNum = Convert.ToInt32(Console.ReadLine());
                    CalculateVoteNum(voteNum, aprilVotedNum, billVotedNum, claireVotedNum);
                }

                catch(FormatException fEx)
                { 
                    //If the user put a number not from 1 to 4
                    Console.WriteLine("You must enter a number from 1 to 4 to vote for a candidater. Please Enter one more time.");
                    voteNum = Convert.ToInt32(Console.ReadLine());
                    CalculateVoteNum(voteNum, aprilVotedNum, billVotedNum, claireVotedNum);
                }
            }

            // Show people results

            Console.WriteLine("Candidate April: " + aprilVotedNum + " votes.");
            Console.WriteLine("Candidate Bill: " + billVotedNum + " votes.");
            Console.WriteLine("Candidate Claire: " + claireVotedNum + "votes.");
        }

        static int CalculateVoteNum (int num, int april, int bill, int claire)
        {

            /* if (num == 1)
            {
                april++;
                return april;
            }
            else if (num == 2)
            {
                bill++;
                return bill;
 
            }
            else if (num == 3)
            {
                claire++;
                return claire;
            }
            else
            {
                //try catch
            }
             */
        }
    }
}
