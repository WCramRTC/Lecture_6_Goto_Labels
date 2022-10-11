using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_6_Goto_Labels
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string USER_NAME = "Will";
            const string PASS = "Cram";
            int attempts = 0;
            int maxAttempts = 3;

        startLogin:;

            Console.WriteLine("Enter your user name");
            string userName = Console.ReadLine();

            Console.WriteLine("Enter your password");
            string password = Console.ReadLine();

            if(PASS == password && userName == USER_NAME)
            {
                Menu();
            }
            else if (attempts < maxAttempts)
            {
                attempts++;
                int attemptsLeft = maxAttempts - attempts;
                
                Console.WriteLine($"Invalid, you have {attemptsLeft}");
                goto startLogin;
            }
            else
            {
                Console.WriteLine("You have failed to login");
                goto exitCode;
     
            }

        exitCode:;


            //Menu();

 
        } // Main

        public static void Menu()
        {
        menuStart:;
            Console.WriteLine("1 - 0 to 10");
            Console.WriteLine("2 - Exit the app");
            Console.Write("Enter a choice: ");
            string userInput = Console.ReadLine();

            if (userInput == "1")
            {
                ZeroToTen();
            }
            else if (userInput == "2")
            {
                Console.WriteLine("Exit the app");
                goto menuEnd;

            }
            else
            {
                Console.WriteLine("Select a valid input");
            }
            goto menuStart; // Where my menu loops
        menuEnd:;
            Console.WriteLine("Good bye");
            Console.ReadKey();
        } // Menu

        //public static void TwentyToFive()
        //{
        //    // loop from 5 to 20

        //    int start = 20;
        //    int end = 5;

        //startOfLoop:; // Label

        //    if (end <= start)
        //    {
        //        Console.WriteLine(start);
        //        start--;
        //    }
        //    else
        //    {
        //        goto endOfLoop;
        //    }

        //    goto startOfLoop; // goto

        //endOfLoop:; // End of loop
        //}

        public static void ZeroToTen()
        {
        // Loop zero to 10
        reenterValues:;
            try
            {
                Console.WriteLine("Looping through numbers");
                Console.Write($"Number to start at - Number has to be greater than {int.MinValue}:");
                int count = int.Parse(Console.ReadLine()); // starting point
                Console.Write($"\nNumber to end at - Number has to be less than {int.MaxValue}:");
                int end = int.Parse(Console.ReadLine()); // starting point
            zeroToTen:;

                if (count <= end)// Ending point {
                {
                    Console.WriteLine(count);
                    count++;
                }
                else
                {
                    goto endZeroToTen;
                }

                goto zeroToTen;
            endZeroToTen:;
            }
            catch
            {
                Console.WriteLine("Enter a valid number");
                goto reenterValues;
            }

  

        }

        public static void TwentyToFive()
        {
            // loop from 5 to 20

            int start = 5;
            int end = 20;

        startOfLoop:; // Label

            if (end >= start)
            {
                Console.WriteLine(end);
                end--;
            }
            else
            {
                goto endOfLoop;
            }

            goto startOfLoop; // goto

        endOfLoop:; // End of loop
        }

        public static void FiveToTwenty()
        {
            // loop from 5 to 20

            int start = 5;
            int end = 20;

        startOfLoop:; // Label

            if (start <= end)
            {
                Console.WriteLine(start);
                start++;
            }
            else
            {
                goto endOfLoop;
            }

            goto startOfLoop; // goto

        endOfLoop:; // End of loop
        }

        public static void InfiniteLoop()
        {

        // Goto and Label
        // goto name of label
        startOfCode:;


            // Label is like a bookmark
            // word - colon - semi cfolon
            Console.WriteLine("1");

            Console.WriteLine("2");
            goto startOfCode;
            Console.WriteLine("3");
        } // InfiniteLoop()

        public static void InClassMathReview()
        {
            //28.Mixing Multiplication and Division: There is a group of 10 people who are ordering pizza.If each person gets 2 slices and each pizza has 4 slices, how many pizzas should they order?
            
             try
            {
                Console.WriteLine("Pizza Calucating App");

                Console.Write("How many people: ");
                int numOfPeople = int.Parse(Console.ReadLine());

                Console.Write("\nHow many slices per person: ");
                int slicePerPerson = int.Parse(Console.ReadLine());

                Console.Write("\nHow many slices per pizza: ");
                int slicesPerPizza = int.Parse(Console.ReadLine());

                int numberOfSlicesNeeded = numOfPeople * slicePerPerson;
                double numOfPizzasNeeded = numberOfSlicesNeeded / (double)slicesPerPizza;


                Console.WriteLine($"THere are {numOfPeople} people" +
                    $"\nThat eat {slicePerPerson} slices each" +
                    $"\nEach pizza has {slicesPerPizza}" +
                    $"We need {numOfPizzasNeeded}");
            }
            catch
            {
                Console.WriteLine("Enter in the right values");
            }



        } // 


    } // class

} // namespace
